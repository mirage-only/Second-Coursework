using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client
{
    public partial class OrdersHistoryPage : Form
    {
        public OrdersHistoryPage()
        {
            InitializeComponent();
        }


        private void OrdersHistoryPage_Load(object sender, EventArgs e)
        {
            var getOrders = new List<ClientMenuItem>();
            var itemForGettingClientMenu = new ClientMenuItem
            {
                ID = 3,
                Name = "0",
                Price = 0
            };

            getOrders.Add(itemForGettingClientMenu);

            var history = ClientController.GetOrders(getOrders);

            dgv_history.AutoGenerateColumns = false;
            
            var column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "numberOfOrder";
            column1.HeaderText = @"Номер заказа";
            dgv_history.Columns.Add(column1);
            
            var column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "totalCost";
            column2.HeaderText = @"Стоимость";
            dgv_history.Columns.Add(column2);
            
            var bindingList = new BindingList<ClientOrder>(history);
            var source = new BindingSource(bindingList, null);
            dgv_history.DataSource = source;
        }
    }
}