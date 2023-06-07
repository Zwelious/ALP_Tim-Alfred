namespace Dealer
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.btn_back = new System.Windows.Forms.Button();
            this.panel_products = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.lvl_total = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.sub_total = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.cmb_payment = new System.Windows.Forms.ComboBox();
            this.lbl_choose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(761, 31);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(111, 36);
            this.btn_back.TabIndex = 38;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel_products
            // 
            this.panel_products.Location = new System.Drawing.Point(0, 89);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(500, 1600);
            this.panel_products.TabIndex = 39;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_title.Location = new System.Drawing.Point(36, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(193, 33);
            this.lbl_title.TabIndex = 40;
            this.lbl_title.Text = "Shopping Cart";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(237, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(833, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(771, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(539, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 79;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(668, 341);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(62, 25);
            this.total.TabIndex = 78;
            this.total.Text = "Rp. 0";
            // 
            // lvl_total
            // 
            this.lvl_total.AutoSize = true;
            this.lvl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_total.Location = new System.Drawing.Point(534, 341);
            this.lvl_total.Name = "lvl_total";
            this.lvl_total.Size = new System.Drawing.Size(68, 25);
            this.lvl_total.TabIndex = 77;
            this.lvl_total.Text = "Total:";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(668, 294);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(62, 25);
            this.tax.TabIndex = 76;
            this.tax.Text = "Rp. 0";
            // 
            // sub_total
            // 
            this.sub_total.AutoSize = true;
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.Location = new System.Drawing.Point(668, 248);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(62, 25);
            this.sub_total.TabIndex = 75;
            this.sub_total.Text = "Rp. 0";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax.Location = new System.Drawing.Point(534, 294);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(121, 25);
            this.lbl_tax.TabIndex = 74;
            this.lbl_tax.Text = "Tax (10%):";
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub.Location = new System.Drawing.Point(534, 248);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(107, 25);
            this.lbl_sub.TabIndex = 73;
            this.lbl_sub.Text = "Sub-total:";
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_checkout.FlatAppearance.BorderSize = 0;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_checkout.Location = new System.Drawing.Point(538, 388);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(137, 50);
            this.btn_checkout.TabIndex = 72;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // cmb_payment
            // 
            this.cmb_payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_payment.FormattingEnabled = true;
            this.cmb_payment.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Bank Transfer"});
            this.cmb_payment.Location = new System.Drawing.Point(537, 192);
            this.cmb_payment.Name = "cmb_payment";
            this.cmb_payment.Size = new System.Drawing.Size(160, 28);
            this.cmb_payment.TabIndex = 71;
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(532, 134);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(277, 25);
            this.lbl_choose.TabIndex = 70;
            this.lbl_choose.Text = "Choose a payment method:";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(940, 715);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.lvl_total);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.sub_total);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.cmb_payment);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel_products);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel_products;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lvl_total;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label sub_total;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ComboBox cmb_payment;
        private System.Windows.Forms.Label lbl_choose;
    }
}