using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
namespace Trainer
{
    public partial class frmWorkout : Form
    {
        public frmWorkout()
        {
            InitializeComponent();
        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=db_gym.sqlite;Version=3");

        private void RefreshDGV()
        {
            //using(SQLiteDataReader reader = cmd.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        dgv_workout.Rows.Add(new object[] { 
            //        reader.GetValue(0),
            //        reader.GetValue(reader.GetOrdinal("name")),
            //        reader.GetValue(reader.GetOrdinal("name_en")),
            //        reader.GetValue(reader.GetOrdinal("target")),
            //        reader.GetValue(reader.GetOrdinal("image")),
            //        reader.GetValue(reader.GetOrdinal("description")),
            //        reader.GetValue(reader.GetOrdinal("status"))
            //        });
            //    }
            //}
            //con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_workout", con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgv_workout.DataSource = dt;
            con.Close();
            //dgv_workout.Columns[0].HeaderText = "شناسه";
            //dgv_workout.Columns[1].HeaderText = "نام حرکت";
            //dgv_workout.Columns[2].HeaderText = "نام انگلیسی";
            //dgv_workout.Columns[3].HeaderText = "عضله هدف";
            //dgv_workout.Columns[4].HeaderText = "تصویر";
            //dgv_workout.Columns[5].HeaderText = "توضیحات";
            //dgv_workout.Columns[6].HeaderText = "وضعیت";

            ////dgv_workout.RowTemplate.Height = 120;
            //dgv_workout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //DataGridViewColumn imgColumn = new DataGridViewColumn();
            //imgColumn = (DataGridViewImageColumn)dgv_workout.Columns[4];

            //adapter.Dispose();
        }

        private void AdjustColumns()
        {

            dgv_workout.Columns["id"].HeaderText = "شناسه";
            dgv_workout.Columns["name"].HeaderText = "نام حرکت";
            dgv_workout.Columns["name_en"].HeaderText = "نام انگلیسی";
            dgv_workout.Columns["target"].HeaderText = "عضله هدف";
            dgv_workout.Columns["image"].HeaderText = "تصویر حرکت";

            ((DataGridViewImageColumn)dgv_workout.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_workout.Columns["description"].HeaderText = "توضیحات";
            dgv_workout.Columns["status"].HeaderText = "وضعیت";




        }
        private void frmWorkout_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            AdjustColumns();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            byte[] data = null;
            SQLiteCommand cmd = new SQLiteCommand("insert into tbl_workout (name, name_en, target, image, description, status) values (@name, @name_en, @target, @image, @description, @status)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@name_en", txt_name_en.Text);
            cmd.Parameters.AddWithValue("@target", txt_target.Text);

            try
            {
                data = File.ReadAllBytes(openFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Parameters.Add("@image", DbType.Binary, data.Length);
            cmd.Parameters["@image"].Value = data;
            cmd.Parameters.AddWithValue("@description", txt_description.Text);
            cmd.Parameters.AddWithValue("@status", 1);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            RefreshDGV();
            AdjustColumns();
            MessageBox.Show("حرکت با موفقیت افزوده شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            byte[] data = null;
            SQLiteCommand cmd = new SQLiteCommand("update tbl_workout set name=@name, name_en=@name_en, target=@target, image=@image, description=@description where id = @id", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", lbl_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@name_en", txt_name_en.Text);
            cmd.Parameters.AddWithValue("@target", txt_target.Text);
            try
            {
                data = File.ReadAllBytes(openFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Parameters.Add("@image", DbType.Binary, data.Length);
            cmd.Parameters["@image"].Value = data;
            cmd.Parameters.AddWithValue("@description", txt_description.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            RefreshDGV();
            AdjustColumns();
            MessageBox.Show("اطلاعات حرکت ویرایش شد", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_workout_DoubleClick(object sender, EventArgs e)
        {
            //pictureBox1.DataBindings.Add("image", ds, "tbl_workout.image", true);
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            MemoryStream ms = new MemoryStream((byte[])(dgv_workout.Rows[dgv_workout.CurrentRow.Index].Cells[4].Value));
            pictureBox1.BackgroundImage = Image.FromStream(ms);
            txt_name.Text = dgv_workout.SelectedRows[0].Cells[1].Value.ToString();
            txt_name_en.Text = dgv_workout.SelectedRows[0].Cells[2].Value.ToString();
            txt_target.Text = dgv_workout.SelectedRows[0].Cells[3].Value.ToString();
            txt_description.Text = dgv_workout.SelectedRows[0].Cells[5].Value.ToString();
            lbl_id.Text = dgv_workout.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void dgv_workout_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا حرکت حدف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteCommand cmd = new SQLiteCommand("delete from tbl_workout where id = @id", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dgv_workout.SelectedRows[0].Cells[0].Value.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDGV();
                AdjustColumns();
                MessageBox.Show("حرکت حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmWorkout_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
