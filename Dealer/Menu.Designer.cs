using System.Windows.Forms;

namespace Dealer
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel_taskbar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_loginUser = new System.Windows.Forms.Button();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_member = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.panel_taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_taskbar
            // 
            this.panel_taskbar.BackColor = System.Drawing.Color.Transparent;
            this.panel_taskbar.Controls.Add(this.lbl_title);
            this.panel_taskbar.Controls.Add(this.pictureBox1);
            this.panel_taskbar.Controls.Add(this.btn_loginUser);
            this.panel_taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_taskbar.Location = new System.Drawing.Point(0, 0);
            this.panel_taskbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_taskbar.Name = "panel_taskbar";
            this.panel_taskbar.Size = new System.Drawing.Size(1015, 109);
            this.panel_taskbar.TabIndex = 20;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // btn_loginUser
            // 
            this.btn_loginUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_loginUser.FlatAppearance.BorderSize = 0;
            this.btn_loginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginUser.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loginUser.Location = new System.Drawing.Point(821, 37);
            this.btn_loginUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loginUser.Name = "btn_loginUser";
            this.btn_loginUser.Size = new System.Drawing.Size(158, 36);
            this.btn_loginUser.TabIndex = 11;
            this.btn_loginUser.Text = "Sign Up Free";
            this.btn_loginUser.UseVisualStyleBackColor = false;
            this.btn_loginUser.Click += new System.EventHandler(this.btn_loginUser_Click);
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.BackColor = System.Drawing.Color.Transparent;
            this.lbl_caption.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_caption.Location = new System.Drawing.Point(378, 430);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(176, 21);
            this.lbl_caption.TabIndex = 25;
            this.lbl_caption.Text = "Don\'t want to sign up?";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_start.Font = new System.Drawing.Font("Bahnschrift", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_start.Location = new System.Drawing.Point(378, 452);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(139, 21);
            this.lbl_start.TabIndex = 26;
            this.lbl_start.Text = "Get started here.";
            this.lbl_start.Click += new System.EventHandler(this.lbl_start_Click);
            this.lbl_start.MouseLeave += new System.EventHandler(this.lbl_start_MouseLeave);
            this.lbl_start.MouseHover += new System.EventHandler(this.lbl_start_MouseHover);
            // 
            // lbl_member
            // 
            this.lbl_member.AutoSize = true;
            this.lbl_member.BackColor = System.Drawing.Color.Transparent;
            this.lbl_member.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_member.Location = new System.Drawing.Point(783, 477);
            this.lbl_member.Name = "lbl_member";
            this.lbl_member.Size = new System.Drawing.Size(137, 18);
            this.lbl_member.TabIndex = 27;
            this.lbl_member.Text = "A member already?";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_login.Location = new System.Drawing.Point(924, 477);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(52, 18);
            this.lbl_login.TabIndex = 28;
            this.lbl_login.Text = "Log in.";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            this.lbl_login.MouseLeave += new System.EventHandler(this.lbl_login_MouseLeave);
            this.lbl_login.MouseHover += new System.EventHandler(this.lbl_login_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 600);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_member);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_caption);
            this.Controls.Add(this.panel_taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel_taskbar.ResumeLayout(false);
            this.panel_taskbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_taskbar;
        private PictureBox pictureBox1;
        private Label lbl_title;
        private Button btn_loginUser;
        private Label lbl_caption;
        private Label lbl_start;
        private Label lbl_member;
        private Label lbl_login;
    }
}