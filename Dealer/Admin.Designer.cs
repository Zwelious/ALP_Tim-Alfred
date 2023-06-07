using System.Windows.Forms;

namespace Dealer
{
    partial class Admin
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
            this.lbl_AdminPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Menu = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_history = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AdminPage
            // 
            this.lbl_AdminPage.AutoSize = true;
            this.lbl_AdminPage.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_AdminPage.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_AdminPage.Location = new System.Drawing.Point(44, 77);
            this.lbl_AdminPage.Name = "lbl_AdminPage";
            this.lbl_AdminPage.Size = new System.Drawing.Size(164, 33);
            this.lbl_AdminPage.TabIndex = 42;
            this.lbl_AdminPage.Text = "Admin Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(567, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 33);
            this.label3.TabIndex = 43;
            this.label3.Text = "Toyoti Dealership";
            // 
            // cmb_Menu
            // 
            this.cmb_Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Menu.FormattingEnabled = true;
            this.cmb_Menu.Items.AddRange(new object[] {
            "Add Cars",
            "Add Accessories"});
            this.cmb_Menu.Location = new System.Drawing.Point(50, 150);
            this.cmb_Menu.Name = "cmb_Menu";
            this.cmb_Menu.Size = new System.Drawing.Size(142, 24);
            this.cmb_Menu.TabIndex = 44;
            this.cmb_Menu.SelectionChangeCommitted += new System.EventHandler(this.cmb_Menu_SelectionChangeCommitted);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_name.Location = new System.Drawing.Point(44, 239);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(162, 33);
            this.lbl_name.TabIndex = 45;
            this.lbl_name.Text = "Item Name:";
            // 
            // cmb_name
            // 
            this.cmb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(50, 308);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(142, 24);
            this.cmb_name.TabIndex = 46;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_color.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_color.Location = new System.Drawing.Point(44, 389);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(145, 33);
            this.lbl_color.TabIndex = 47;
            this.lbl_color.Text = "Car Color:";
            // 
            // cmb_color
            // 
            this.cmb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Items.AddRange(new object[] {
            "Red",
            "Black",
            "White",
            "Blue",
            "Silver",
            "Cyan",
            "Yellow"});
            this.cmb_color.Location = new System.Drawing.Point(47, 458);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(142, 24);
            this.cmb_color.TabIndex = 48;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(416, 270);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(181, 36);
            this.btn_Add.TabIndex = 49;
            this.btn_Add.Text = "Add to dealership";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(410, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "Stock:";
            // 
            // numeric_stock
            // 
            this.numeric_stock.Location = new System.Drawing.Point(416, 211);
            this.numeric_stock.Name = "numeric_stock";
            this.numeric_stock.Size = new System.Drawing.Size(120, 22);
            this.numeric_stock.TabIndex = 51;
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Font = new System.Drawing.Font("Elephant", 15F);
            this.lbl_history.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_history.Location = new System.Drawing.Point(410, 370);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(266, 33);
            this.lbl_history.TabIndex = 52;
            this.lbl_history.Text = "Transaction History";
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_open.Location = new System.Drawing.Point(416, 429);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(108, 36);
            this.btn_open.TabIndex = 53;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(697, 517);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 36);
            this.btn_back.TabIndex = 54;
            this.btn_back.Text = "Logout";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(847, 600);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.numeric_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_color);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.cmb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.cmb_Menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_AdminPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_AdminPage;
        private Label label3;
        private ComboBox cmb_Menu;
        private Label lbl_name;
        private ComboBox cmb_name;
        private Label lbl_color;
        private ComboBox cmb_color;
        private Button btn_Add;
        private Label label1;
        private NumericUpDown numeric_stock;
        private Label lbl_history;
        private Button btn_open;
        private Button btn_back;
    }
}