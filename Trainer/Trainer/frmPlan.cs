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
    public partial class frmPlan : Form
    {
        public frmPlan()
        {
            InitializeComponent();
        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=db_gym.sqlite;Version=3");

        private void RefreshDGV()
        {
            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_workout", con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgv_workout.DataSource = dt;
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
        private void RefresPlanhDGV()
        {
            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_plan where profile_id = @profile_id", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@profile_id", lbl_profile_id.Text);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgv_plan.DataSource = dt;

        }

        private void AdjustPlanColumns()
        {

            dgv_plan.Columns["id"].HeaderText = "شناسه";
            dgv_plan.Columns["profile_id"].HeaderText = "شناسه پروفایل";
            dgv_plan.Columns["workout_id"].HeaderText = "شناسه حرکت";
            dgv_plan.Columns["sets"].HeaderText = "تعداد ست";
            dgv_plan.Columns["counts"].HeaderText = "تعداد";
            dgv_plan.Columns["rest"].HeaderText = "استراحت";
            dgv_plan.Columns["tempo"].HeaderText = "تمپو";
            dgv_plan.Columns["system"].HeaderText = "سیستم";
            dgv_plan.Columns["weight"].HeaderText = "وزن";
            dgv_plan.Columns["day"].HeaderText = "روز";
            dgv_plan.Columns["description"].HeaderText = "توضیحات";
            dgv_plan.Columns["created"].HeaderText = "تاریخ";
            dgv_plan.Columns["status"].HeaderText = "وضعیت";




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            AdjustColumns();
            RefresPlanhDGV();
            AdjustPlanColumns();
        }

        private void dgv_workout_DoubleClick(object sender, EventArgs e)
        {
            lbl_workout_id.Text = dgv_workout.SelectedRows[0].Cells[0].Value.ToString();
            lbl_workout.Text = dgv_workout.SelectedRows[0].Cells[1].Value.ToString();
            pic_workout.BackgroundImageLayout = ImageLayout.Zoom;
            MemoryStream ms = new MemoryStream((byte[])(dgv_workout.Rows[dgv_workout.CurrentRow.Index].Cells[4].Value));
            pic_workout.BackgroundImage = Image.FromStream(ms);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_workout where name like @name", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", "%" + textBox1.Text + "%");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_workout.DataSource = dataTable;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("insert into tbl_plan (profile_id, workout_id, sets, counts, rest, tempo, system, weight, day, description, status) values (@profile_id, @workout_id, @sets, @counts, @rest, @tempo, @system, @weight, @day, @description, @status)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@profile_id", lbl_profile_id.Text);
            cmd.Parameters.AddWithValue("@workout_id", lbl_workout_id.Text);
            cmd.Parameters.AddWithValue("@sets", txt_sets.Text);
            cmd.Parameters.AddWithValue("@counts", txt_count.Text);
            cmd.Parameters.AddWithValue("@rest", txt_rests.Text);
            cmd.Parameters.AddWithValue("@tempo", txt_tempo.Text);
            cmd.Parameters.AddWithValue("@system", txt_system.Text);
            cmd.Parameters.AddWithValue("@weight", txt_weight.Text);
            cmd.Parameters.AddWithValue("@day", txt_day.Text);
            cmd.Parameters.AddWithValue("@description", txt_description.Text);
            cmd.Parameters.AddWithValue("@status", 1);

            con.Open();

            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("اضافه شد");
                RefresPlanhDGV();

            }
            con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("update tbl_plan set workout_id=@workout_id, sets=@sets, counts=@counts, rest=@rest, tempo=@tempo, system=@system, weight=@weight, day=@day, description=@description where id=@id", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lbl_plan_id.Text));
            cmd.Parameters.AddWithValue("@workout_id", Convert.ToInt32(lbl_workout_id.Text));
            cmd.Parameters.AddWithValue("@sets", Convert.ToInt32(txt_sets.Text));
            cmd.Parameters.AddWithValue("@counts", txt_count.Text);
            cmd.Parameters.AddWithValue("@rest", txt_rests.Text);
            cmd.Parameters.AddWithValue("@tempo", txt_tempo.Text);
            cmd.Parameters.AddWithValue("@system", txt_system.Text);
            cmd.Parameters.AddWithValue("@weight", txt_weight.Text);
            cmd.Parameters.AddWithValue("@day", Convert.ToInt32(txt_day.Text));
            cmd.Parameters.AddWithValue("@description", txt_description.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                RefresPlanhDGV();
                MessageBox.Show("ویرایش شد");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void deletemenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا حرکت حدف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteCommand cmd = new SQLiteCommand("delete from tbl_plan where id = @id", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dgv_plan.SelectedRows[0].Cells[0].Value.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefresPlanhDGV();
                MessageBox.Show("حرکت حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editmenu_Click(object sender, EventArgs e)
        {
            lbl_plan_id.Text = dgv_plan.SelectedRows[0].Cells[0].Value.ToString();
            lbl_workout_id.Text = dgv_plan.SelectedRows[0].Cells[2].Value.ToString();
            txt_sets.Text = dgv_plan.SelectedRows[0].Cells[3].Value.ToString();
            txt_count.Text = dgv_plan.SelectedRows[0].Cells[4].Value.ToString();
            txt_rests.Text = dgv_plan.SelectedRows[0].Cells[5].Value.ToString();
            txt_tempo.Text = dgv_plan.SelectedRows[0].Cells[6].Value.ToString();
            txt_system.Text = dgv_plan.SelectedRows[0].Cells[7].Value.ToString();
            txt_weight.Text = dgv_plan.SelectedRows[0].Cells[8].Value.ToString();
            txt_day.Text = dgv_plan.SelectedRows[0].Cells[9].Value.ToString();
            txt_description.Text = dgv_plan.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
