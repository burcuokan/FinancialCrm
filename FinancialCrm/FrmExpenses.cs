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
using System.Data.SqlClient;

namespace FinancialCrm
{
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmExpenses_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = (from spending in db.Spendings
                                        join category in db.Categories
                                        on spending.CategoryId equals category.CategoryId
                                        select new
                                        {

                                            spending.SpendingId,
                                            spending.SpendingTitle,
                                            spending.SpendingAmount,
                                            spending.SpendingDate,
                                            CategoryName = category.CategoryName
                                        }).ToList();
        }

        private void btnExpenseList_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource= (from spending in db.Spendings
                         join category in db.Categories
                         on spending.CategoryId equals category.CategoryId
                         select new
                         {

                             spending.SpendingId,
                             spending.SpendingTitle,
                             spending.SpendingAmount,
                             spending.SpendingDate,
                             categoryName = category.CategoryName
                         }).ToList();
        }

        private void btnCreateExpense_Click(object sender, EventArgs e)
        {
            string spendingTitle = txtTitle.Text;
            decimal spendingAmount = decimal.Parse(txtExpenseAmount.Text);
            DateTime date = Convert.ToDateTime(txtDate.Text);
            int categoryName = int.Parse(txtCategory.Text);


            Spendings spendings = new Spendings();
            spendings.SpendingTitle =spendingTitle ;
            spendings.SpendingAmount = spendingAmount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Giderler Başarılı Bir Şekilde Sisteme Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = (from spending in db.Spendings
                                        join category in db.Categories
                                        on spending.CategoryId equals category.CategoryId
                                        select new
                                        {

                                            spending.SpendingId,
                                            spending.SpendingTitle,
                                            spending.SpendingAmount,
                                            spending.SpendingDate,
                                            categoryName = category.CategoryName
                                        }).ToList();
        }

        private void btnRemoveExpense_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtExpenseId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sistemden Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = (from spending in db.Spendings
                                        join category in db.Categories
                                        on spending.CategoryId equals category.CategoryId
                                        select new
                                        {

                                            spending.SpendingId,
                                            spending.SpendingTitle,
                                            spending.SpendingAmount,
                                            spending.SpendingDate,
                                            categoryName = category.CategoryName
                                        }).ToList();
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtExpenseId.Text);
            string spendingTitle = txtTitle.Text;
            decimal spendingAmount = decimal.Parse(txtExpenseAmount.Text);

            var values = db.Spendings.Find(id);

            values.SpendingId = id;
            values.SpendingTitle = spendingTitle;
            values.SpendingAmount = spendingAmount;
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sistemde Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = (from spending in db.Spendings
                                        join category in db.Categories
                                        on spending.CategoryId equals category.CategoryId
                                        select new
                                        {

                                            spending.SpendingId,
                                            spending.SpendingTitle,
                                            spending.SpendingAmount,
                                            spending.SpendingDate,
                                            categoryName = category.CategoryName
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
