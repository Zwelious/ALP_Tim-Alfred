namespace Dealer
{
    partial class CarBuy
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
            this.picture_car = new System.Windows.Forms.PictureBox();
            this.lbl_carName = new System.Windows.Forms.Label();
            this.lbl_stripe = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_trans = new System.Windows.Forms.Label();
            this.lbl_colour = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_availability = new System.Windows.Forms.Label();
            this.car_name = new System.Windows.Forms.Label();
            this.car_type = new System.Windows.Forms.Label();
            this.car_trans = new System.Windows.Forms.Label();
            this.car_price = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_car)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_car
            // 
            this.picture_car.Location = new System.Drawing.Point(44, 40);
            this.picture_car.Name = "picture_car";
            this.picture_car.Size = new System.Drawing.Size(531, 418);
            this.picture_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_car.TabIndex = 0;
            this.picture_car.TabStop = false;
            // 
            // lbl_carName
            // 
            this.lbl_carName.AutoSize = true;
            this.lbl_carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carName.Location = new System.Drawing.Point(37, 503);
            this.lbl_carName.Name = "lbl_carName";
            this.lbl_carName.Size = new System.Drawing.Size(189, 42);
            this.lbl_carName.TabIndex = 1;
            this.lbl_carName.Text = "Car name";
            // 
            // lbl_stripe
            // 
            this.lbl_stripe.AutoSize = true;
            this.lbl_stripe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stripe.Location = new System.Drawing.Point(384, 503);
            this.lbl_stripe.Name = "lbl_stripe";
            this.lbl_stripe.Size = new System.Drawing.Size(31, 42);
            this.lbl_stripe.TabIndex = 2;
            this.lbl_stripe.Text = "-";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(415, 503);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(178, 42);
            this.lbl_color.TabIndex = 3;
            this.lbl_color.Text = "Car color";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(597, 40);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(113, 25);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Car name:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(597, 112);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(101, 25);
            this.lbl_type.TabIndex = 5;
            this.lbl_type.Text = "Car type:";
            // 
            // lbl_trans
            // 
            this.lbl_trans.AutoSize = true;
            this.lbl_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trans.Location = new System.Drawing.Point(597, 183);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(181, 25);
            this.lbl_trans.TabIndex = 6;
            this.lbl_trans.Text = "Car transmission:";
            // 
            // lbl_colour
            // 
            this.lbl_colour.AutoSize = true;
            this.lbl_colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_colour.Location = new System.Drawing.Point(597, 252);
            this.lbl_colour.Name = "lbl_colour";
            this.lbl_colour.Size = new System.Drawing.Size(107, 25);
            this.lbl_colour.TabIndex = 7;
            this.lbl_colour.Text = "Car color:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(597, 342);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(68, 25);
            this.lbl_price.TabIndex = 8;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_availability
            // 
            this.lbl_availability.AutoSize = true;
            this.lbl_availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_availability.Location = new System.Drawing.Point(597, 430);
            this.lbl_availability.Name = "lbl_availability";
            this.lbl_availability.Size = new System.Drawing.Size(193, 25);
            this.lbl_availability.TabIndex = 9;
            this.lbl_availability.Text = "___ unit(s) available!";
            // 
            // car_name
            // 
            this.car_name.AutoSize = true;
            this.car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_name.Location = new System.Drawing.Point(597, 76);
            this.car_name.Name = "car_name";
            this.car_name.Size = new System.Drawing.Size(61, 25);
            this.car_name.TabIndex = 10;
            this.car_name.Text = "name";
            // 
            // car_type
            // 
            this.car_type.AutoSize = true;
            this.car_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_type.Location = new System.Drawing.Point(597, 148);
            this.car_type.Name = "car_type";
            this.car_type.Size = new System.Drawing.Size(49, 25);
            this.car_type.TabIndex = 11;
            this.car_type.Text = "type";
            // 
            // car_trans
            // 
            this.car_trans.AutoSize = true;
            this.car_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_trans.Location = new System.Drawing.Point(597, 218);
            this.car_trans.Name = "car_trans";
            this.car_trans.Size = new System.Drawing.Size(121, 25);
            this.car_trans.TabIndex = 12;
            this.car_trans.Text = "transmission";
            // 
            // car_price
            // 
            this.car_price.AutoSize = true;
            this.car_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_price.Location = new System.Drawing.Point(597, 386);
            this.car_price.Name = "car_price";
            this.car_price.Size = new System.Drawing.Size(41, 25);
            this.car_price.TabIndex = 13;
            this.car_price.Text = "Rp.";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(44, 593);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 36);
            this.btn_back.TabIndex = 35;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_checkout.FlatAppearance.BorderSize = 0;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_checkout.Location = new System.Drawing.Point(685, 531);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(223, 65);
            this.btn_checkout.TabIndex = 36;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // CarBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(991, 685);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.car_price);
            this.Controls.Add(this.car_trans);
            this.Controls.Add(this.car_type);
            this.Controls.Add(this.car_name);
            this.Controls.Add(this.lbl_availability);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_colour);
            this.Controls.Add(this.lbl_trans);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_stripe);
            this.Controls.Add(this.lbl_carName);
            this.Controls.Add(this.picture_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_car;
        private System.Windows.Forms.Label lbl_carName;
        private System.Windows.Forms.Label lbl_stripe;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_trans;
        private System.Windows.Forms.Label lbl_colour;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_availability;
        private System.Windows.Forms.Label car_name;
        private System.Windows.Forms.Label car_type;
        private System.Windows.Forms.Label car_trans;
        private System.Windows.Forms.Label car_price;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_checkout;
    }
}