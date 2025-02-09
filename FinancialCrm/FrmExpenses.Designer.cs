namespace FinancialCrm
{
    partial class FrmExpenses
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtExpenseId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.btnRemoveExpense = new System.Windows.Forms.Button();
            this.btnCreateExpense = new System.Windows.Forms.Button();
            this.btnExpenseList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankTransactions = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btninvoices = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(190, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 201);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtExpenseAmount);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.txtExpenseId);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnUpdateExpense);
            this.panel2.Controls.Add(this.btnRemoveExpense);
            this.panel2.Controls.Add(this.btnCreateExpense);
            this.panel2.Controls.Add(this.btnExpenseList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(190, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 164);
            this.panel2.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategory.Location = new System.Drawing.Point(422, 39);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(190, 27);
            this.txtCategory.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(357, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kategori:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDate.Location = new System.Drawing.Point(422, 8);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(190, 27);
            this.txtDate.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(379, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarih:";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpenseAmount.Location = new System.Drawing.Point(122, 71);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(190, 27);
            this.txtExpenseAmount.TabIndex = 15;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(122, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(190, 27);
            this.txtTitle.TabIndex = 14;
            // 
            // txtExpenseId
            // 
            this.txtExpenseId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpenseId.Location = new System.Drawing.Point(122, 5);
            this.txtExpenseId.Name = "txtExpenseId";
            this.txtExpenseId.Size = new System.Drawing.Size(190, 27);
            this.txtExpenseId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(66, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Başlık:";
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExpense.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateExpense.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateExpense.Location = new System.Drawing.Point(475, 116);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(111, 32);
            this.btnUpdateExpense.TabIndex = 11;
            this.btnUpdateExpense.Text = "Gider Güncelle";
            this.btnUpdateExpense.UseVisualStyleBackColor = false;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // btnRemoveExpense
            // 
            this.btnRemoveExpense.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemoveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveExpense.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveExpense.Location = new System.Drawing.Point(357, 116);
            this.btnRemoveExpense.Name = "btnRemoveExpense";
            this.btnRemoveExpense.Size = new System.Drawing.Size(112, 32);
            this.btnRemoveExpense.TabIndex = 10;
            this.btnRemoveExpense.Text = "Gider Sil";
            this.btnRemoveExpense.UseVisualStyleBackColor = false;
            this.btnRemoveExpense.Click += new System.EventHandler(this.btnRemoveExpense_Click);
            // 
            // btnCreateExpense
            // 
            this.btnCreateExpense.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateExpense.ForeColor = System.Drawing.Color.Black;
            this.btnCreateExpense.Location = new System.Drawing.Point(239, 116);
            this.btnCreateExpense.Name = "btnCreateExpense";
            this.btnCreateExpense.Size = new System.Drawing.Size(112, 32);
            this.btnCreateExpense.TabIndex = 9;
            this.btnCreateExpense.Text = "Gider Ekle";
            this.btnCreateExpense.UseVisualStyleBackColor = false;
            this.btnCreateExpense.Click += new System.EventHandler(this.btnCreateExpense_Click);
            // 
            // btnExpenseList
            // 
            this.btnExpenseList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExpenseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenseList.ForeColor = System.Drawing.Color.Black;
            this.btnExpenseList.Location = new System.Drawing.Point(121, 116);
            this.btnExpenseList.Name = "btnExpenseList";
            this.btnExpenseList.Size = new System.Drawing.Size(112, 32);
            this.btnExpenseList.TabIndex = 8;
            this.btnExpenseList.Text = "Gider Listesi";
            this.btnExpenseList.UseVisualStyleBackColor = false;
            this.btnExpenseList.Click += new System.EventHandler(this.btnExpenseList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gider Tutarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankTransactions);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btninvoices);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 374);
            this.panel1.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(26, 281);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 32);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(26, 243);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(145, 32);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(26, 205);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(145, 32);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankTransactions
            // 
            this.btnBankTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnBankTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransactions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankTransactions.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankTransactions.Location = new System.Drawing.Point(26, 167);
            this.btnBankTransactions.Name = "btnBankTransactions";
            this.btnBankTransactions.Size = new System.Drawing.Size(145, 32);
            this.btnBankTransactions.TabIndex = 4;
            this.btnBankTransactions.Text = "Banka Hareketleri";
            this.btnBankTransactions.UseVisualStyleBackColor = false;
            this.btnBankTransactions.Click += new System.EventHandler(this.btnBankTransactions_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillForm.Location = new System.Drawing.Point(26, 129);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(145, 32);
            this.btnBillForm.TabIndex = 3;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btninvoices
            // 
            this.btninvoices.BackColor = System.Drawing.Color.Transparent;
            this.btninvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btninvoices.ForeColor = System.Drawing.Color.Transparent;
            this.btninvoices.Location = new System.Drawing.Point(26, 91);
            this.btninvoices.Name = "btninvoices";
            this.btninvoices.Size = new System.Drawing.Size(145, 32);
            this.btninvoices.TabIndex = 2;
            this.btninvoices.Text = "Faturalar";
            this.btninvoices.UseVisualStyleBackColor = false;
            this.btninvoices.Click += new System.EventHandler(this.btninvoices_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.Location = new System.Drawing.Point(26, 53);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(145, 32);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategories.Location = new System.Drawing.Point(26, 15);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(145, 32);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(180)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 35);
            this.panel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giderler";
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 411);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Button btnRemoveExpense;
        private System.Windows.Forms.Button btnCreateExpense;
        private System.Windows.Forms.Button btnExpenseList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankTransactions;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btninvoices;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtExpenseId;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
    }
}