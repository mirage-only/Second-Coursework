namespace Client
{
    sealed partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonHistoryOfOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_menu
            // 
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(52, 82);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.RowTemplate.Height = 24;
            this.dgv_menu.Size = new System.Drawing.Size(311, 286);
            this.dgv_menu.TabIndex = 0;
            this.dgv_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellContentClick);
            // 
            // dgv_order
            // 
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(438, 82);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.Size = new System.Drawing.Size(311, 286);
            this.dgv_order.TabIndex = 1;
            // 
            // labelMenu
            // 
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(119, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(244, 50);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Меню";
            // 
            // labelOrder
            // 
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.Location = new System.Drawing.Point(505, 9);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(244, 50);
            this.labelOrder.TabIndex = 3;
            this.labelOrder.Text = "Заказ";
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeOrder.Location = new System.Drawing.Point(478, 374);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(243, 67);
            this.buttonMakeOrder.TabIndex = 4;
            this.buttonMakeOrder.Text = "Cделать заказ";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // buttonHistoryOfOrders
            // 
            this.buttonHistoryOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistoryOfOrders.Location = new System.Drawing.Point(86, 374);
            this.buttonHistoryOfOrders.Name = "buttonHistoryOfOrders";
            this.buttonHistoryOfOrders.Size = new System.Drawing.Size(243, 67);
            this.buttonHistoryOfOrders.TabIndex = 5;
            this.buttonHistoryOfOrders.Text = "История заказов";
            this.buttonHistoryOfOrders.UseVisualStyleBackColor = true;
            this.buttonHistoryOfOrders.Click += new System.EventHandler(this.buttonHistoryOfOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHistoryOfOrders);
            this.Controls.Add(this.buttonMakeOrder);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.dgv_menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonHistoryOfOrders;

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonMakeOrder;

        private System.Windows.Forms.DataGridView dgv_order;

        private System.Windows.Forms.DataGridView dgv_menu;

        #endregion
    }
}