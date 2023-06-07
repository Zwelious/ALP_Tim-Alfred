namespace Dealer
{
    partial class History
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.btn_carsales = new System.Windows.Forms.Button();
            this.btn_accsales = new System.Windows.Forms.Button();
            this.lbl_trans = new System.Windows.Forms.Label();
            this.trans_id = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_only = new System.Windows.Forms.Label();
            this.item_details = new System.Windows.Forms.Label();
            this.total_paid = new System.Windows.Forms.Label();
            this.admin_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(388, 36);
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
            this.btn_back.Location = new System.Drawing.Point(728, 35);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(158, 36);
            this.btn_back.TabIndex = 37;
            this.btn_back.Text = "Back to menu";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::Dealer.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(332, 41);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(33, 31);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 36;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_search.Location = new System.Drawing.Point(41, 44);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(271, 22);
            this.txt_search.TabIndex = 35;
            this.txt_search.Text = "Item name";
            // 
            // dgv_history
            // 
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Location = new System.Drawing.Point(41, 173);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.RowHeadersWidth = 51;
            this.dgv_history.RowTemplate.Height = 24;
            this.dgv_history.Size = new System.Drawing.Size(571, 481);
            this.dgv_history.TabIndex = 39;
            this.dgv_history.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_history_CellClick);
            // 
            // btn_carsales
            // 
            this.btn_carsales.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_carsales.FlatAppearance.BorderSize = 0;
            this.btn_carsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carsales.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carsales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_carsales.Location = new System.Drawing.Point(41, 100);
            this.btn_carsales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_carsales.Name = "btn_carsales";
            this.btn_carsales.Size = new System.Drawing.Size(158, 36);
            this.btn_carsales.TabIndex = 40;
            this.btn_carsales.Text = "Car Transactions";
            this.btn_carsales.UseVisualStyleBackColor = false;
            this.btn_carsales.Click += new System.EventHandler(this.btn_carsales_Click);
            // 
            // btn_accsales
            // 
            this.btn_accsales.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_accsales.FlatAppearance.BorderSize = 0;
            this.btn_accsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accsales.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accsales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_accsales.Location = new System.Drawing.Point(233, 100);
            this.btn_accsales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_accsales.Name = "btn_accsales";
            this.btn_accsales.Size = new System.Drawing.Size(243, 36);
            this.btn_accsales.TabIndex = 41;
            this.btn_accsales.Text = "Accessorries Transactions";
            this.btn_accsales.UseVisualStyleBackColor = false;
            this.btn_accsales.Click += new System.EventHandler(this.btn_accsales_Click);
            // 
            // lbl_trans
            // 
            this.lbl_trans.AutoSize = true;
            this.lbl_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trans.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trans.ForeColor = System.Drawing.Color.Black;
            this.lbl_trans.Location = new System.Drawing.Point(633, 173);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(143, 24);
            this.lbl_trans.TabIndex = 42;
            this.lbl_trans.Text = "Transaction ID:";
            // 
            // trans_id
            // 
            this.trans_id.AutoSize = true;
            this.trans_id.BackColor = System.Drawing.Color.Transparent;
            this.trans_id.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_id.ForeColor = System.Drawing.Color.Black;
            this.trans_id.Location = new System.Drawing.Point(633, 211);
            this.trans_id.Name = "trans_id";
            this.trans_id.Size = new System.Drawing.Size(83, 24);
            this.trans_id.TabIndex = 43;
            this.trans_id.Text = "trans_id";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.BackColor = System.Drawing.Color.Transparent;
            this.lbl_item.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ForeColor = System.Drawing.Color.Black;
            this.lbl_item.Location = new System.Drawing.Point(633, 256);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(56, 24);
            this.lbl_item.TabIndex = 44;
            this.lbl_item.Text = "Item:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(633, 499);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(191, 24);
            this.lbl_total.TabIndex = 45;
            this.lbl_total.Text = "Total paid (tax incl.):";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.Black;
            this.lbl_admin.Location = new System.Drawing.Point(633, 572);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(161, 24);
            this.lbl_admin.TabIndex = 46;
            this.lbl_admin.Text = "Admin in charge:";
            // 
            // lbl_only
            // 
            this.lbl_only.AutoSize = true;
            this.lbl_only.BackColor = System.Drawing.Color.Transparent;
            this.lbl_only.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_only.ForeColor = System.Drawing.Color.Black;
            this.lbl_only.Location = new System.Drawing.Point(633, 596);
            this.lbl_only.Name = "lbl_only";
            this.lbl_only.Size = new System.Drawing.Size(131, 21);
            this.lbl_only.TabIndex = 47;
            this.lbl_only.Text = "(Car sales only)";
            // 
            // item_details
            // 
            this.item_details.AutoSize = true;
            this.item_details.BackColor = System.Drawing.Color.Transparent;
            this.item_details.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_details.ForeColor = System.Drawing.Color.Black;
            this.item_details.Location = new System.Drawing.Point(633, 299);
            this.item_details.Name = "item_details";
            this.item_details.Size = new System.Drawing.Size(120, 24);
            this.item_details.TabIndex = 48;
            this.item_details.Text = "item_details";
            // 
            // total_paid
            // 
            this.total_paid.AutoSize = true;
            this.total_paid.BackColor = System.Drawing.Color.Transparent;
            this.total_paid.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_paid.ForeColor = System.Drawing.Color.Black;
            this.total_paid.Location = new System.Drawing.Point(633, 535);
            this.total_paid.Name = "total_paid";
            this.total_paid.Size = new System.Drawing.Size(55, 24);
            this.total_paid.TabIndex = 49;
            this.total_paid.Text = "Rp. 0";
            // 
            // admin_name
            // 
            this.admin_name.AutoSize = true;
            this.admin_name.BackColor = System.Drawing.Color.Transparent;
            this.admin_name.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_name.ForeColor = System.Drawing.Color.Black;
            this.admin_name.Location = new System.Drawing.Point(636, 629);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(20, 24);
            this.admin_name.TabIndex = 50;
            this.admin_name.Text = "-";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(937, 741);
            this.Controls.Add(this.admin_name);
            this.Controls.Add(this.total_paid);
            this.Controls.Add(this.item_details);
            this.Controls.Add(this.lbl_only);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.trans_id);
            this.Controls.Add(this.lbl_trans);
            this.Controls.Add(this.btn_accsales);
            this.Controls.Add(this.btn_carsales);
            this.Controls.Add(this.dgv_history);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.Button btn_carsales;
        private System.Windows.Forms.Button btn_accsales;
        private System.Windows.Forms.Label lbl_trans;
        private System.Windows.Forms.Label trans_id;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_only;
        private System.Windows.Forms.Label item_details;
        private System.Windows.Forms.Label total_paid;
        private System.Windows.Forms.Label admin_name;
    }
}