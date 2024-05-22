using System.ComponentModel;

namespace Client
{
    partial class OrdersHistoryPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dgv_history = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_history
            // 
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Location = new System.Drawing.Point(0, 2);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.ReadOnly = true;
            this.dgv_history.RowTemplate.Height = 24;
            this.dgv_history.Size = new System.Drawing.Size(798, 449);
            this.dgv_history.TabIndex = 0;
            // 
            // OrdersHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_history);
            this.Name = "OrdersHistoryPage";
            this.Text = "OrdersHistoryPage";
            this.Load += new System.EventHandler(this.OrdersHistoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgv_history;

        #endregion
    }
}