using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client
{
    public sealed partial class MainPage : Form
    {
        private readonly List<ClientMenuItem> _selectedItems = new List<ClientMenuItem>();
        
        public MainPage()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ClientMenuItem> getMenu = new List<ClientMenuItem>();
            ClientMenuItem itemForGettingClientMenu = new ClientMenuItem
            {
                ID = 1,
                Name = "0",
                Price = 0
            };

            getMenu.Add(itemForGettingClientMenu);

            var menu = ClientController.GetMenuAndProcessTheOrder(getMenu);
            
            var bindingList = new BindingList<ClientMenuItem>(menu);
            var source = new BindingSource(bindingList, null);
            dgv_menu.DataSource = source;
            
            dgv_menu.Columns["ID"].Visible = false;
        }

        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgv_menu[0, e.RowIndex].Value);
                var name = dgv_menu[1, e.RowIndex].Value.ToString();
                var price = Convert.ToInt32(dgv_menu[2, e.RowIndex].Value);
                
                ClientMenuItem selectedItem = new ClientMenuItem
                {
                    ID = id,
                    Name = name,
                    Price = price
                };
                
                _selectedItems.Add(selectedItem);
                
                var bindingListOrder = new BindingList<ClientMenuItem>(_selectedItems);
                var sourceOrder = new BindingSource(bindingListOrder, null);
                dgv_order.DataSource = sourceOrder;
            
                dgv_order.Columns["ID"].Visible = false;
                
                dgv_order.Refresh();
            }
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            List<ClientMenuItem> answer = ClientController.GetMenuAndProcessTheOrder(_selectedItems);
            
            _selectedItems.Clear();
            dgv_order.Rows.Clear();

            MessageBox.Show($@"Заказ совершен, номер заказа {answer[0].ID}, сумма заказа составила {answer[0].Price} рубля(ей)");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<ClientMenuItem> saveAndExitProgram = new List<ClientMenuItem>();
            ClientMenuItem itemForGettingClientMenu = new ClientMenuItem
            {
                ID = 2,
                Name = "0",
                Price = 0
            };

            saveAndExitProgram.Add(itemForGettingClientMenu);
            
            ClientController.CloseClientAndSaveOrders(saveAndExitProgram);
        }

        private void buttonHistoryOfOrders_Click(object sender, EventArgs e)
        {
            var page = new OrdersHistoryPage();

            page.Location = Location;
            page.Height = Height;
            page.Width = Width;
            
            page.Show();
            //Close();
        }
    }
}