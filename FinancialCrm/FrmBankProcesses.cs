using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            //var values = db.BankProcesses.ToList();
            //dataGridView1.DataSource = values;

            dataGridView1.DataSource = (from process in db.BankProcesses
                                        join banks in db.Banks
                                        on process.BankId equals banks.BankId
                                        select new
                                        {

                                            process.BankProcessId,
                                            process.Description,
                                            process.ProcessDate,
                                            process.ProcessType,
                                            process.Amount,
                                            BankName = banks.BankTitle
                                        }).ToList();
        }

        private void btnTransactionList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateNewTransaction_Click(object sender, EventArgs e)
        {
            string processName = txtProcessDescription.Text;  
            DateTime processDate = DateTime.Parse(txtProcessDate.Text);
            string processType = txtProcessType.Text;
            decimal processAmount = decimal.Parse(txtProcessAmount.Text);
            int BankName = int.Parse(txtBankId.Text);
          
            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.Description = processName;
            bankProcesses.ProcessType = processType;
            bankProcesses.Amount = processAmount;
            bankProcesses.ProcessDate = processDate;
            bankProcesses.BankId = BankName;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Sisteme Eklendi ", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //var values = db.BankProcesses.ToList();
            //dataGridView1.DataSource = values;


            dataGridView1.DataSource = (from process in db.BankProcesses
                                        join banks in db.Banks
                                        on process.BankId equals banks.BankId
                                        select new
                                        {

                                            process.BankProcessId,
                                            process.Description,
                                            process.ProcessDate,
                                            process.ProcessType,
                                            process.Amount,
                                            BankName = banks.BankTitle
                                        }).ToList();
        }

        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);

            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Sistemden Silindi ", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //var values = db.BankProcesses.ToList();
            //dataGridView1.DataSource = values;


            dataGridView1.DataSource = (from process in db.BankProcesses
                                        join banks in db.Banks
                                        on process.BankId equals banks.BankId
                                        select new
                                        {

                                            process.BankProcessId,
                                            process.Description,
                                            process.ProcessDate,
                                            process.ProcessType,
                                            process.Amount,
                                            BankName = banks.BankTitle
                                        }).ToList();
        }

        private void btnUpdaterTansaction_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessId.Text);
            string processName = txtProcessDescription.Text;
            string processType = txtProcessType.Text;
            decimal processAmount = decimal.Parse(txtProcessAmount.Text);
            DateTime processDate = DateTime.Parse(txtProcessDate.Text);
            int BankName = int.Parse(txtBankId.Text);
            

            var values = db.BankProcesses.Find(id);
            values.BankProcessId = id;
            values.Description = processName;
            values.ProcessType = processType;
            values.Amount = processAmount;
            values.ProcessDate = processDate;
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Sistemde Güncellendi ", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //var values2 = db.BankProcesses.ToList();
            //dataGridView1.DataSource = values2;


            dataGridView1.DataSource = (from process in db.BankProcesses
                                        join banks in db.Banks
                                        on process.BankId equals banks.BankId
                                        select new
                                        {

                                            process.BankProcessId,
                                            process.Description,
                                            process.ProcessDate,
                                            process.ProcessType,
                                            process.Amount,
                                            BankName = banks.BankTitle
                                        }).ToList();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();

        }

        private void btninvoices_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Hide();
        }

        private void btnBankTransactions_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
