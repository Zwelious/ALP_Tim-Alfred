using System.Windows.Forms;

namespace Dealer
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture_password = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_clearFields = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_logo
            // 
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(85, 30);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(181, 117);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bauhaus 93", 20F);
            this.lbl_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_title.Location = new System.Drawing.Point(115, 194);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(115, 39);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "LOG IN";
            // 
            // picture_user
            // 
            this.picture_user.Image = global::Dealer.Properties.Resources.user;
            this.picture_user.Location = new System.Drawing.Point(41, 268);
            this.picture_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(27, 36);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_user.TabIndex = 2;
            this.picture_user.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(41, 312);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(41, 403);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 5;
            // 
            // picture_password
            // 
            this.picture_password.Image = global::Dealer.Properties.Resources.user;
            this.picture_password.Location = new System.Drawing.Point(41, 359);
            this.picture_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_password.Name = "picture_password";
            this.picture_password.Size = new System.Drawing.Size(27, 36);
            this.picture_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_password.TabIndex = 4;
            this.picture_password.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(41, 455);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(270, 31);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_clearFields
            // 
            this.lbl_clearFields.AutoSize = true;
            this.lbl_clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_clearFields.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_clearFields.Location = new System.Drawing.Point(204, 433);
            this.lbl_clearFields.Name = "lbl_clearFields";
            this.lbl_clearFields.Size = new System.Drawing.Size(98, 18);
            this.lbl_clearFields.TabIndex = 7;
            this.lbl_clearFields.Text = "Clear Fields";
            this.lbl_clearFields.Click += new System.EventHandler(this.lbl_clearFields_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_exit.Location = new System.Drawing.Point(155, 539);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(36, 18);
            this.lbl_exit.TabIndex = 8;
            this.lbl_exit.Text = "Exit";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_email.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_email.Location = new System.Drawing.Point(75, 272);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.MaxLength = 50;
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 31);
            this.txt_email.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_password.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_password.Location = new System.Drawing.Point(75, 364);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.MaxLength = 6;
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(235, 31);
            this.txt_password.TabIndex = 10;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(41, 493);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(270, 31);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(41, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(41, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(56, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Toyoti Dealership";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(92, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "An admin?";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_admin.Location = new System.Drawing.Point(177, 576);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(80, 16);
            this.lbl_admin.TabIndex = 34;
            this.lbl_admin.Text = "Click here.";
            this.lbl_admin.Click += new System.EventHandler(this.lbl_admin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(351, 616);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
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
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picture_logo;
        private Label lbl_title;
        private PictureBox picture_user;
        private Panel panel1;
        private Panel panel2;
        private PictureBox picture_password;
        private Button btn_login;
        private Label lbl_clearFields;
        private Label lbl_exit;
        private TextBox txt_email;
        private TextBox txt_password;
        private Button btn_register;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_admin;
    }
}