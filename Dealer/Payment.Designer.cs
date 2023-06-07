namespace Dealer
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lbl_choose = new System.Windows.Forms.Label();
            this.cmb_payment = new System.Windows.Forms.ComboBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_cust = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.car_name = new System.Windows.Forms.Label();
            this.car_no = new System.Windows.Forms.Label();
            this.cust_email = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_thankyou = new System.Windows.Forms.Label();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.sub_total = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.lvl_total = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(79, 370);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(277, 25);
            this.lbl_choose.TabIndex = 7;
            this.lbl_choose.Text = "Choose a payment method:";
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
            this.cmb_payment.Location = new System.Drawing.Point(84, 428);
            this.cmb_payment.Name = "cmb_payment";
            this.cmb_payment.Size = new System.Drawing.Size(160, 28);
            this.cmb_payment.TabIndex = 8;
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_checkout.FlatAppearance.BorderSize = 0;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_checkout.Location = new System.Drawing.Point(84, 628);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(104, 56);
            this.btn_checkout.TabIndex = 37;
            this.btn_checkout.Text = "Pay";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lbl_cust
            // 
            this.lbl_cust.AutoSize = true;
            this.lbl_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust.Location = new System.Drawing.Point(79, 269);
            this.lbl_cust.Name = "lbl_cust";
            this.lbl_cust.Size = new System.Drawing.Size(169, 25);
            this.lbl_cust.TabIndex = 38;
            this.lbl_cust.Text = "Customer email:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(79, 69);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(113, 25);
            this.lbl_name.TabIndex = 39;
            this.lbl_name.Text = "Car name:";
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no.Location = new System.Drawing.Point(79, 171);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(115, 25);
            this.lbl_no.TabIndex = 40;
            this.lbl_no.Text = "No. mesin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(585, 418);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(727, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // car_name
            // 
            this.car_name.AutoSize = true;
            this.car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_name.Location = new System.Drawing.Point(81, 121);
            this.car_name.Name = "car_name";
            this.car_name.Size = new System.Drawing.Size(107, 25);
            this.car_name.TabIndex = 44;
            this.car_name.Text = "car_name";
            // 
            // car_no
            // 
            this.car_no.AutoSize = true;
            this.car_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_no.Location = new System.Drawing.Point(81, 220);
            this.car_no.Name = "car_no";
            this.car_no.Size = new System.Drawing.Size(78, 25);
            this.car_no.TabIndex = 45;
            this.car_no.Text = "car_no";
            // 
            // cust_email
            // 
            this.cust_email.AutoSize = true;
            this.cust_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_email.Location = new System.Drawing.Point(81, 319);
            this.cust_email.Name = "cust_email";
            this.cust_email.Size = new System.Drawing.Size(115, 25);
            this.cust_email.TabIndex = 46;
            this.cust_email.Text = "cust_email";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(443, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(424, 259);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_thankyou
            // 
            this.lbl_thankyou.AutoSize = true;
            this.lbl_thankyou.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_thankyou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thankyou.ForeColor = System.Drawing.Color.White;
            this.lbl_thankyou.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_thankyou.Location = new System.Drawing.Point(464, 319);
            this.lbl_thankyou.Name = "lbl_thankyou";
            this.lbl_thankyou.Size = new System.Drawing.Size(342, 25);
            this.lbl_thankyou.TabIndex = 48;
            this.lbl_thankyou.Text = "THANK YOU FOR PURCHASING!";
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub.Location = new System.Drawing.Point(81, 484);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(107, 25);
            this.lbl_sub.TabIndex = 49;
            this.lbl_sub.Text = "Sub-total:";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax.Location = new System.Drawing.Point(81, 530);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(121, 25);
            this.lbl_tax.TabIndex = 50;
            this.lbl_tax.Text = "Tax (10%):";
            // 
            // sub_total
            // 
            this.sub_total.AutoSize = true;
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.Location = new System.Drawing.Point(215, 484);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(62, 25);
            this.sub_total.TabIndex = 51;
            this.sub_total.Text = "Rp. 0";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(215, 530);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(62, 25);
            this.tax.TabIndex = 52;
            this.tax.Text = "Rp. 0";
            // 
            // lvl_total
            // 
            this.lvl_total.AutoSize = true;
            this.lvl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_total.Location = new System.Drawing.Point(81, 577);
            this.lvl_total.Name = "lvl_total";
            this.lvl_total.Size = new System.Drawing.Size(68, 25);
            this.lvl_total.TabIndex = 53;
            this.lvl_total.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(215, 577);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(62, 25);
            this.total.TabIndex = 54;
            this.total.Text = "Rp. 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(86, 563);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 55;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(930, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.lvl_total);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.sub_total);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.lbl_thankyou);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cust_email);
            this.Controls.Add(this.car_no);
            this.Controls.Add(this.car_name);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_cust);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.cmb_payment);
            this.Controls.Add(this.lbl_choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.ComboBox cmb_payment;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label lbl_cust;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label car_name;
        private System.Windows.Forms.Label car_no;
        private System.Windows.Forms.Label cust_email;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_thankyou;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label sub_total;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label lvl_total;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Panel panel1;
    }
}