namespace Restaurant2
{
    partial class RegistrationForm
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
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_roles = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_name
            // 
            this.txtbx_name.Location = new System.Drawing.Point(125, 88);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(258, 22);
            this.txtbx_name.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(122, 55);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(122, 134);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Location = new System.Drawing.Point(125, 167);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(258, 22);
            this.txtbx_email.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(122, 220);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(125, 252);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(258, 22);
            this.txtbx_password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Roles";
            // 
            // cmbx_roles
            // 
            this.cmbx_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_roles.FormattingEnabled = true;
            this.cmbx_roles.Location = new System.Drawing.Point(125, 339);
            this.cmbx_roles.Name = "cmbx_roles";
            this.cmbx_roles.Size = new System.Drawing.Size(258, 24);
            this.cmbx_roles.TabIndex = 8;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(175, 402);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(164, 39);
            this.Register.TabIndex = 9;
            this.Register.Text = "Complete Registration";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 495);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.cmbx_roles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtbx_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtbx_name);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_roles;
        private System.Windows.Forms.Button Register;
    }
}