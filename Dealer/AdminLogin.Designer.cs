namespace Dealer
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_adminID = new System.Windows.Forms.TextBox();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_clearFields = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture_password = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(39, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(39, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Admin ID";
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_password.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_password.Location = new System.Drawing.Point(73, 368);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.MaxLength = 6;
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(235, 31);
            this.txt_password.TabIndex = 37;
            // 
            // txt_adminID
            // 
            this.txt_adminID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_adminID.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_adminID.Location = new System.Drawing.Point(73, 276);
            this.txt_adminID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_adminID.MaxLength = 50;
            this.txt_adminID.Multiline = true;
            this.txt_adminID.Name = "txt_adminID";
            this.txt_adminID.Size = new System.Drawing.Size(235, 31);
            this.txt_adminID.TabIndex = 36;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_exit.Location = new System.Drawing.Point(116, 525);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(112, 18);
            this.lbl_exit.TabIndex = 35;
            this.lbl_exit.Text = "Back to menu";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // lbl_clearFields
            // 
            this.lbl_clearFields.AutoSize = true;
            this.lbl_clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_clearFields.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_clearFields.Location = new System.Drawing.Point(210, 448);
            this.lbl_clearFields.Name = "lbl_clearFields";
            this.lbl_clearFields.Size = new System.Drawing.Size(98, 18);
            this.lbl_clearFields.TabIndex = 34;
            this.lbl_clearFields.Text = "Clear Fields";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(39, 470);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(270, 31);
            this.btn_login.TabIndex = 33;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(39, 407);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 32;
            // 
            // picture_password
            // 
            this.picture_password.Image = global::Dealer.Properties.Resources.user;
            this.picture_password.Location = new System.Drawing.Point(39, 363);
            this.picture_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_password.Name = "picture_password";
            this.picture_password.Size = new System.Drawing.Size(27, 36);
            this.picture_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_password.TabIndex = 31;
            this.picture_password.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(39, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 30;
            // 
            // picture_user
            // 
            this.picture_user.Image = global::Dealer.Properties.Resources.user;
            this.picture_user.Location = new System.Drawing.Point(39, 272);
            this.picture_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(27, 36);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_user.TabIndex = 29;
            this.picture_user.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bauhaus 93", 20F);
            this.lbl_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_title.Location = new System.Drawing.Point(64, 191);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(219, 39);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "ADMIN LOGIN";
            // 
            // picture_logo
            // 
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(83, 34);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(181, 117);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 27;
            this.picture_logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(54, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "Toyoti Dealership";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_adminID);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_clearFields);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picture_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture_user);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.picture_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_adminID;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_clearFields;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Label label3;
    }
}