namespace Dealer
{
    partial class Purchase_Success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Success));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_next = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_title.ForeColor = System.Drawing.Color.Orchid;
            this.lbl_title.Location = new System.Drawing.Point(58, 149);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(159, 33);
            this.lbl_title.TabIndex = 25;
            this.lbl_title.Text = "Thank you, ";
            // 
            // lbl_next
            // 
            this.lbl_next.AutoSize = true;
            this.lbl_next.BackColor = System.Drawing.Color.Transparent;
            this.lbl_next.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_next.ForeColor = System.Drawing.Color.Orchid;
            this.lbl_next.Location = new System.Drawing.Point(215, 149);
            this.lbl_next.Name = "lbl_next";
            this.lbl_next.Size = new System.Drawing.Size(75, 33);
            this.lbl_next.TabIndex = 26;
            this.lbl_next.Text = "next.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(129, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "for your purchase!";
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.BackColor = System.Drawing.Color.Transparent;
            this.lbl_back.Font = new System.Drawing.Font("Bahnschrift", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_back.ForeColor = System.Drawing.Color.Orchid;
            this.lbl_back.Location = new System.Drawing.Point(60, 407);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(118, 21);
            this.lbl_back.TabIndex = 28;
            this.lbl_back.Text = "Back to menu.";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // Purchase_Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(876, 474);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_next);
            this.Controls.Add(this.lbl_title);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Success";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Purchase_Success_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_back;
    }
}