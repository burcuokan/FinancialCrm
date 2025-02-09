namespace FinancialCrm
{
    partial class FrmBankProcesses
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
            this.txtBankId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdaterTansaction = new System.Windows.Forms.Button();
            this.btnRemoveTransaction = new System.Windows.Forms.Button();
            this.btnCreateNewTransaction = new System.Windows.Forms.Button();
            this.btnTransactionList = new System.Windows.Forms.Button();
            this.txtProcessDescription = new System.Windows.Forms.TextBox();
            this.txtProcessType = new System.Windows.Forms.TextBox();
            this.txtProcessDate = new System.Windows.Forms.TextBox();
            this.txtProcessAmount = new System.Windows.Forms.TextBox();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel3.Location = new System.Drawing.Point(192, 209);
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
            this.panel2.Controls.Add(this.txtBankId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnUpdaterTansaction);
            this.panel2.Controls.Add(this.btnRemoveTransaction);
            this.panel2.Controls.Add(this.btnCreateNewTransaction);
            this.panel2.Controls.Add(this.btnTransactionList);
            this.panel2.Controls.Add(this.txtProcessDescription);
            this.panel2.Controls.Add(this.txtProcessType);
            this.panel2.Controls.Add(this.txtProcessDate);
            this.panel2.Controls.Add(this.txtProcessAmount);
            this.panel2.Controls.Add(this.txtProcessId);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(192, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 164);
            this.panel2.TabIndex = 5;
            // 
            // txtBankId
            // 
            this.txtBankId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankId.Location = new System.Drawing.Point(364, 80);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.Size = new System.Drawing.Size(190, 27);
            this.txtBankId.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(294, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Banka Id:";
            // 
            // btnUpdaterTansaction
            // 
            this.btnUpdaterTansaction.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdaterTansaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdaterTansaction.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdaterTansaction.ForeColor = System.Drawing.Color.Black;
            this.btnUpdaterTansaction.Location = new System.Drawing.Point(443, 119);
            this.btnUpdaterTansaction.Name = "btnUpdaterTansaction";
            this.btnUpdaterTansaction.Size = new System.Drawing.Size(111, 32);
            this.btnUpdaterTansaction.TabIndex = 22;
            this.btnUpdaterTansaction.Text = "İşlem Güncelle";
            this.btnUpdaterTansaction.UseVisualStyleBackColor = false;
            this.btnUpdaterTansaction.Click += new System.EventHandler(this.btnUpdaterTansaction_Click);
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemoveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTransaction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveTransaction.Location = new System.Drawing.Point(323, 118);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Size = new System.Drawing.Size(112, 32);
            this.btnRemoveTransaction.TabIndex = 21;
            this.btnRemoveTransaction.Text = "İşlem Sil";
            this.btnRemoveTransaction.UseVisualStyleBackColor = false;
            this.btnRemoveTransaction.Click += new System.EventHandler(this.btnRemoveTransaction_Click);
            // 
            // btnCreateNewTransaction
            // 
            this.btnCreateNewTransaction.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreateNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewTransaction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateNewTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewTransaction.Location = new System.Drawing.Point(195, 118);
            this.btnCreateNewTransaction.Name = "btnCreateNewTransaction";
            this.btnCreateNewTransaction.Size = new System.Drawing.Size(120, 32);
            this.btnCreateNewTransaction.TabIndex = 20;
            this.btnCreateNewTransaction.Text = "Yeni İşlem Ekle";
            this.btnCreateNewTransaction.UseVisualStyleBackColor = false;
            this.btnCreateNewTransaction.Click += new System.EventHandler(this.btnCreateNewTransaction_Click);
            // 
            // btnTransactionList
            // 
            this.btnTransactionList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTransactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransactionList.ForeColor = System.Drawing.Color.Black;
            this.btnTransactionList.Location = new System.Drawing.Point(75, 118);
            this.btnTransactionList.Name = "btnTransactionList";
            this.btnTransactionList.Size = new System.Drawing.Size(112, 32);
            this.btnTransactionList.TabIndex = 19;
            this.btnTransactionList.Text = "İşlem Listesi";
            this.btnTransactionList.UseVisualStyleBackColor = false;
            this.btnTransactionList.Click += new System.EventHandler(this.btnTransactionList_Click);
            // 
            // txtProcessDescription
            // 
            this.txtProcessDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessDescription.Location = new System.Drawing.Point(364, 8);
            this.txtProcessDescription.Name = "txtProcessDescription";
            this.txtProcessDescription.Size = new System.Drawing.Size(190, 27);
            this.txtProcessDescription.TabIndex = 18;
            // 
            // txtProcessType
            // 
            this.txtProcessType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessType.Location = new System.Drawing.Point(364, 44);
            this.txtProcessType.Name = "txtProcessType";
            this.txtProcessType.Size = new System.Drawing.Size(190, 27);
            this.txtProcessType.TabIndex = 17;
            // 
            // txtProcessDate
            // 
            this.txtProcessDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessDate.Location = new System.Drawing.Point(76, 42);
            this.txtProcessDate.Name = "txtProcessDate";
            this.txtProcessDate.Size = new System.Drawing.Size(190, 27);
            this.txtProcessDate.TabIndex = 16;
            // 
            // txtProcessAmount
            // 
            this.txtProcessAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessAmount.Location = new System.Drawing.Point(76, 77);
            this.txtProcessAmount.Name = "txtProcessAmount";
            this.txtProcessAmount.Size = new System.Drawing.Size(190, 27);
            this.txtProcessAmount.TabIndex = 15;
            // 
            // txtProcessId
            // 
            this.txtProcessId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessId.Location = new System.Drawing.Point(76, 7);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.Size = new System.Drawing.Size(190, 27);
            this.txtProcessId.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(291, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(330, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tür:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id:";
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
            this.panel1.Location = new System.Drawing.Point(2, 36);
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
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 35);
            this.panel4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Banka Hareketleri";
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 415);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcesses";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcessDescription;
        private System.Windows.Forms.TextBox txtProcessType;
        private System.Windows.Forms.TextBox txtProcessDate;
        private System.Windows.Forms.TextBox txtProcessAmount;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.Button btnUpdaterTansaction;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.Button btnCreateNewTransaction;
        private System.Windows.Forms.Button btnTransactionList;
        private System.Windows.Forms.TextBox txtBankId;
        private System.Windows.Forms.Label label7;
    }
}