namespace Restaurant2
{
    partial class OfficiantForm
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
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.lbl_orders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(26, 104);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(681, 315);
            this.dataGridOrders.TabIndex = 0;
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Location = new System.Drawing.Point(33, 53);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(52, 17);
            this.lbl_orders.TabIndex = 2;
            this.lbl_orders.Text = "Orders";
            // 
            // OfficiantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.dataGridOrders);
            this.Name = "OfficiantForm";
            this.Text = "OfficiantForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label lbl_orders;
    }
}