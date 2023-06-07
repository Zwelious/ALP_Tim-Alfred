namespace Dealer
{
    partial class Home
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
            this.panel_taskbar = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_userEmail = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_taskbar
            // 
            this.panel_taskbar.BackColor = System.Drawing.Color.LightSalmon;
            this.panel_taskbar.Controls.Add(this.pictureBox6);
            this.panel_taskbar.Controls.Add(this.lbl_login);
            this.panel_taskbar.Controls.Add(this.lbl_title);
            this.panel_taskbar.Controls.Add(this.pictureBox1);
            this.panel_taskbar.Controls.Add(this.lbl_userEmail);
            this.panel_taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_taskbar.Location = new System.Drawing.Point(0, 0);
            this.panel_taskbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_taskbar.Name = "panel_taskbar";
            this.panel_taskbar.Size = new System.Drawing.Size(968, 109);
            this.panel_taskbar.TabIndex = 21;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Dealer.Properties.Resources.user;
            this.pictureBox6.Location = new System.Drawing.Point(885, 27);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_login.Location = new System.Drawing.Point(880, 76);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(49, 18);
            this.lbl_login.TabIndex = 34;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            this.lbl_login.MouseLeave += new System.EventHandler(this.lbl_login_MouseLeave);
            this.lbl_login.MouseHover += new System.EventHandler(this.lbl_login_MouseHover);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_title.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_title.Location = new System.Drawing.Point(145, 37);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(236, 33);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "Toyoti Dealership";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dealer.Properties.Resources._28211739_7382295;
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_userEmail
            // 
            this.lbl_userEmail.AutoSize = true;
            this.lbl_userEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userEmail.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userEmail.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_userEmail.Location = new System.Drawing.Point(815, 45);
            this.lbl_userEmail.Name = "lbl_userEmail";
            this.lbl_userEmail.Size = new System.Drawing.Size(59, 21);
            this.lbl_userEmail.TabIndex = 36;
            this.lbl_userEmail.Text = " Guest";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_menu.Location = new System.Drawing.Point(0, 104);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(968, 693);
            this.panel_menu.TabIndex = 27;
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_footer.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_footer.Location = new System.Drawing.Point(12, 814);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(309, 24);
            this.lbl_footer.TabIndex = 36;
            this.lbl_footer.Text = "Toyoti® 2023. All rights reserved.";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_admin.Location = new System.Drawing.Point(893, 854);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(54, 18);
            this.lbl_admin.TabIndex = 37;
            this.lbl_admin.Text = "Admin";
            this.lbl_admin.Click += new System.EventHandler(this.lbl_admin_Click);
            this.lbl_admin.MouseEnter += new System.EventHandler(this.lbl_admin_MouseEnter);
            this.lbl_admin.MouseHover += new System.EventHandler(this.lbl_admin_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 848);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Contact Us +62 82136990080";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(968, 920);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_taskbar.ResumeLayout(false);
            this.panel_taskbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_taskbar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_userEmail;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label1;
    }
}