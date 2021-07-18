using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Trainer
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=db_gym.sqlite;Version=3");

        private void RefreshDGV()
        {
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_users", con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_users.DataSource = dt;
        }

        private void AdjustColumns()
        {
            dgv_users.Columns["id"].HeaderText = "شناسه";
            dgv_users.Columns["name"].HeaderText = "نام";
            dgv_users.Columns["family"].HeaderText = "نام خانوادگی";
            dgv_users.Columns["phone"].HeaderText = "شماره موبایل";
            dgv_users.Columns["email"].HeaderText = "ایمیل";
            dgv_users.Columns["joined"].HeaderText = "تاریخ عضویت";
            dgv_users.Columns["status"].HeaderText = "وضعیت کاربر";
            dgv_users.AutoSize = true;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("insert into tbl_users (name,family,phone,email, status) values(@name, @family, @phone, @email, @status) ", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@family", txt_family.Text);
            cmd.Parameters.AddWithValue("@phone", txt_mobile.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@status", 1);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            RefreshDGV();
            AdjustColumns();
            MessageBox.Show("کاربر با موفقیت اضافه شد", "افزودن کاربر", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            AdjustColumns();
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_users where phone like @phone", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@phone", "%" + txt_mobile.Text + "%");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_users.DataSource = dataTable;
        }

        private void dgv_users_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا کاربر حدف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteCommand cmd = new SQLiteCommand("delete from tbl_users where id = @id", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dgv_users.SelectedRows[0].Cells[0].Value.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDGV();
                AdjustColumns();
                MessageBox.Show("کاربر حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        DataGridViewPrinter MyDataGridViewPrinter;
        
        private bool SetupThePrinting()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowCurrentPage = false;
            printDialog.AllowPrintToFile = false;
            printDialog.AllowSomePages = false;
            printDialog.PrintToFile = false;
            printDialog.ShowHelp = false;
            printDialog.ShowNetwork = false;

            if (printDialog.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            MyPrintDocument.DocumentName = "";
            MyPrintDocument.PrinterSettings = printDialog.PrinterSettings;
            MyPrintDocument.PrinterSettings.DefaultPageSettings.Landscape = true;
            MyPrintDocument.DefaultPageSettings.Landscape = true;
            MyPrintDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(40, 40, 40, 40);
            MyDataGridViewPrinter = new DataGridViewPrinter(dgv_users, MyPrintDocument, true, true, "لیست کاربران", new System.Drawing.Font("IRYekan", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;

        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = MyPrintDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void dgv_users_DoubleClick(object sender, EventArgs e)
        {
            lbl_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
            txt_family.Text = dgv_users.SelectedRows[0].Cells[2].Value.ToString();
            txt_mobile.Text = dgv_users.SelectedRows[0].Cells[3].Value.ToString();
            txt_email.Text = dgv_users.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("update tbl_users set name=@name, family=@family, phone=@phone, email=@email where id = @id", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", lbl_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@family", txt_family.Text);
            cmd.Parameters.AddWithValue("@phone", txt_mobile.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            RefreshDGV();
            AdjustColumns();
            MessageBox.Show("اطلاعات کاربر ویرایش شد", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfile profile = new frmProfile();
                profile.lbl_id.Text = lbl_id.Text;
                profile.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
