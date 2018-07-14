namespace Restaurant2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
       
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txbx_table = new System.Windows.Forms.TextBox();
            this.lbl_table = new System.Windows.Forms.Label();
            this.lbl_officiant = new System.Windows.Forms.Label();
            this.cmbx_officiants = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txtbx_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cmbx_name = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_logadmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.txbx_table);
            this.groupBox1.Controls.Add(this.lbl_table);
            this.groupBox1.Controls.Add(this.lbl_officiant);
            this.groupBox1.Controls.Add(this.cmbx_officiants);
            this.groupBox1.Controls.Add(this.btnComplete);
            this.groupBox1.Controls.Add(this.btn_order);
            this.groupBox1.Controls.Add(this.lbl_count);
            this.groupBox1.Controls.Add(this.txtbx_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_price);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.cmbx_name);
            this.groupBox1.Controls.Add(this.lbl_category);
            this.groupBox1.Controls.Add(this.cmbx_category);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(573, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(374, 119);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(115, 24);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txbx_table
            // 
            this.txbx_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_table.Location = new System.Drawing.Point(187, 26);
            this.txbx_table.Name = "txbx_table";
            this.txbx_table.Size = new System.Drawing.Size(23, 30);
            this.txbx_table.TabIndex = 13;
            this.txbx_table.Text = "1";
            // 
            // lbl_table
            // 
            this.lbl_table.AutoSize = true;
            this.lbl_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_table.Location = new System.Drawing.Point(113, 28);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Size = new System.Drawing.Size(73, 25);
            this.lbl_table.TabIndex = 12;
            this.lbl_table.Text = "Table: ";
            // 
            // lbl_officiant
            // 
            this.lbl_officiant.AutoSize = true;
            this.lbl_officiant.Location = new System.Drawing.Point(115, 84);
            this.lbl_officiant.Name = "lbl_officiant";
            this.lbl_officiant.Size = new System.Drawing.Size(60, 17);
            this.lbl_officiant.TabIndex = 11;
            this.lbl_officiant.Text = "Officiant";
            // 
            // cmbx_officiants
            // 
            this.cmbx_officiants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_officiants.FormattingEnabled = true;
            this.cmbx_officiants.Location = new System.Drawing.Point(115, 119);
            this.cmbx_officiants.Name = "cmbx_officiants";
            this.cmbx_officiants.Size = new System.Drawing.Size(210, 24);
            this.cmbx_officiants.TabIndex = 10;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(351, 433);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(138, 28);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(119, 433);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(149, 28);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(339, 349);
            this.lbl_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(45, 17);
            this.lbl_count.TabIndex = 7;
            this.lbl_count.Text = "Count";
            // 
            // txtbx_count
            // 
            this.txtbx_count.Location = new System.Drawing.Point(351, 376);
            this.txtbx_count.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_count.Name = "txtbx_count";
            this.txtbx_count.Size = new System.Drawing.Size(138, 22);
            this.txtbx_count.TabIndex = 6;
            this.txtbx_count.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(119, 376);
            this.txtbx_price.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.ReadOnly = true;
            this.txtbx_price.Size = new System.Drawing.Size(149, 22);
            this.txtbx_price.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(115, 269);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // cmbx_name
            // 
            this.cmbx_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_name.FormattingEnabled = true;
            this.cmbx_name.Location = new System.Drawing.Point(119, 301);
            this.cmbx_name.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_name.Name = "cmbx_name";
            this.cmbx_name.Size = new System.Drawing.Size(370, 24);
            this.cmbx_name.TabIndex = 2;
            this.cmbx_name.SelectedValueChanged += new System.EventHandler(this.cmbx_name_SelectedValueChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(115, 190);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(65, 17);
            this.lbl_category.TabIndex = 1;
            this.lbl_category.Text = "Category";
            // 
            // cmbx_category
            // 
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(119, 222);
            this.cmbx_category.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(370, 24);
            this.cmbx_category.TabIndex = 0;
            this.cmbx_category.SelectedIndexChanged += new System.EventHandler(this.cmbx_category_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(663, 133);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(604, 313);
            this.dataGrid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(923, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Price:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(1084, 466);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(24, 25);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "0";
            // 
            // btn_logadmin
            // 
            this.btn_logadmin.Location = new System.Drawing.Point(1066, 34);
            this.btn_logadmin.Name = "btn_logadmin";
            this.btn_logadmin.Size = new System.Drawing.Size(164, 48);
            this.btn_logadmin.TabIndex = 12;
            this.btn_logadmin.Text = "Log as admin";
            this.btn_logadmin.UseVisualStyleBackColor = true;
            this.btn_logadmin.Click += new System.EventHandler(this.btn_logadmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 565);
            this.Controls.Add(this.btn_logadmin);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.TextBox txtbx_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox cmbx_name;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_logadmin;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lbl_officiant;
        private System.Windows.Forms.ComboBox cmbx_officiants;
        private System.Windows.Forms.TextBox txbx_table;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Button btn_start;
    }
}