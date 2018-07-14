namespace Restaurant2
{
    partial class ManagerForm
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
            this.lbl_officiants = new System.Windows.Forms.Label();
            this.combo_officiants = new System.Windows.Forms.ComboBox();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_officiants
            // 
            this.lbl_officiants.AutoSize = true;
            this.lbl_officiants.Location = new System.Drawing.Point(31, 50);
            this.lbl_officiants.Name = "lbl_officiants";
            this.lbl_officiants.Size = new System.Drawing.Size(67, 17);
            this.lbl_officiants.TabIndex = 0;
            this.lbl_officiants.Text = "Officiants";
            // 
            // combo_officiants
            // 
            this.combo_officiants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_officiants.FormattingEnabled = true;
            this.combo_officiants.Location = new System.Drawing.Point(34, 107);
            this.combo_officiants.Name = "combo_officiants";
            this.combo_officiants.Size = new System.Drawing.Size(288, 24);
            this.combo_officiants.TabIndex = 1;
            this.combo_officiants.SelectedIndexChanged += new System.EventHandler(this.cmbx_officiants_SelectedIndexChanged);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(34, 229);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(630, 231);
            this.dataGridOrders.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orders";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.combo_officiants);
            this.Controls.Add(this.lbl_officiants);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_officiants;
        private System.Windows.Forms.ComboBox combo_officiants;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label label1;
    }
}