using System.Windows.Forms;

namespace Dealer
{
    partial class Accessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accessories));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_acc = new System.Windows.Forms.Panel();
            this.btn_cart = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(393, 30);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 36);
            this.btn_reset.TabIndex = 38;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(733, 29);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(158, 36);
            this.btn_back.TabIndex = 37;
            this.btn_back.Text = "Back to menu";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_search
            // 
            this.txt_search.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_search.Location = new System.Drawing.Point(46, 38);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(271, 22);
            this.txt_search.TabIndex = 35;
            // 
            // panel_acc
            // 
            this.panel_acc.Location = new System.Drawing.Point(3, 89);
            this.panel_acc.Name = "panel_acc";
            this.panel_acc.Size = new System.Drawing.Size(938, 2000);
            this.panel_acc.TabIndex = 39;
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cart.BackgroundImage")));
            this.btn_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cart.ForeColor = System.Drawing.Color.Black;
            this.btn_cart.Location = new System.Drawing.Point(656, 20);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(55, 55);
            this.btn_cart.TabIndex = 0;
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::Dealer.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(337, 35);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(33, 31);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 36;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Accessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(937, 741);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.panel_acc);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accessories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Accessories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_reset;
        private Button btn_back;
        private PictureBox btn_search;
        private TextBox txt_search;
        private Panel panel_acc;
        private Button btn_cart;
    }
}