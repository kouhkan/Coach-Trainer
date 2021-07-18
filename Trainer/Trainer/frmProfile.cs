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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=db_gym.sqlite;Version=3");


        private void RefreshDGV()
        {
            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("select * from tbl_profile where user_id = @user_id", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user_id", lbl_id.Text);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgv_profile.DataSource = dt;
        }

        private void AdjustColumns()
        {

            dgv_profile.Columns["id"].HeaderText = "شناسه";
            dgv_profile.Columns["user_id"].HeaderText = "شناسه کاربر";
            dgv_profile.Columns["img_front"].HeaderText = "جلو";
            ((DataGridViewImageColumn)dgv_profile.Columns["img_front"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_profile.Columns["img_back"].HeaderText = "پشت";
            ((DataGridViewImageColumn)dgv_profile.Columns["img_back"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_profile.Columns["img_right"].HeaderText = "راست";
            ((DataGridViewImageColumn)dgv_profile.Columns["img_right"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_profile.Columns["img_left"].HeaderText = "چپ";
            ((DataGridViewImageColumn)dgv_profile.Columns["img_left"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_profile.Columns["age"].HeaderText = "سن";
            dgv_profile.Columns["height"].HeaderText = "قد";
            dgv_profile.Columns["weight"].HeaderText = "وزن";
            dgv_profile.Columns["blood"].HeaderText = "گروه خون";
            dgv_profile.Columns["arm"].HeaderText = "ساعد";
            dgv_profile.Columns["neck"].HeaderText = "گردن";
            dgv_profile.Columns["forearm"].HeaderText = "بازو";
            dgv_profile.Columns["chest"].HeaderText = "سینه";
            dgv_profile.Columns["back"].HeaderText = "کمر";
            dgv_profile.Columns["hip"].HeaderText = "باسن";
            dgv_profile.Columns["shoulder"].HeaderText = "شانه";
            dgv_profile.Columns["tight"].HeaderText = "ران";
            dgv_profile.Columns["leg"].HeaderText = "ساق";
            dgv_profile.Columns["flank"].HeaderText = "پهلو";
            dgv_profile.Columns["sleep"].HeaderText = "ساعت خواب";
            dgv_profile.Columns["awake"].HeaderText = "ساعت بیداری";
            dgv_profile.Columns["allergy"].HeaderText = "آلرژی";
            dgv_profile.Columns["workout_time"].HeaderText = "ساعت تمرین";
            dgv_profile.Columns["platin"].HeaderText = "پلاتین";
            dgv_profile.Columns["joint_problem"].HeaderText = "مفصل";
            dgv_profile.Columns["suger_blood"].HeaderText = "قند خون";
            dgv_profile.Columns["blood_problem"].HeaderText = "فشار خون";
            dgv_profile.Columns["surgery"].HeaderText = "سابقه عمل";
            dgv_profile.Columns["broken"].HeaderText = "سابقه شکستگی";
            dgv_profile.Columns["spinal"].HeaderText = "ستون فقرات";
            dgv_profile.Columns["hate_food"].HeaderText = "تنفر غذایی";
            dgv_profile.Columns["created"].HeaderText = "تاریخ";
            dgv_profile.Columns["status"].HeaderText = "وضعیت";

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void frmProfile_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            AdjustColumns();
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pic_back.Image = Image.FromFile(openFileDialog2.FileName);
            }

        }

        private void pic_front_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_front.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pic_right_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                pic_right.Image = Image.FromFile(openFileDialog3.FileName);
            }
        }

        private void pic_left_Click(object sender, EventArgs e)
        {
            openFileDialog4.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png";
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                pic_left.Image = Image.FromFile(openFileDialog4.FileName);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            byte[] data1 = null;
            byte[] data2 = null;
            byte[] data3 = null;
            byte[] data4 = null;
            SQLiteCommand cmd = new SQLiteCommand("insert into tbl_profile (user_id, img_front, img_back, img_right, img_left, age, height, weight, blood, arm, neck, forearm, chest, back, hip, shoulder, tight, leg, flank, sleep, awake, workout_time, allergy, platin, joint_problem, suger_blood, blood_problem, surgery, broken, spinal, hate_food, status) values (@user_id, @img_front, @img_back, @img_right, @img_left, @age, @height, @weight, @blood, @arm, @neck, @forearm, @chest, @back, @hip, @shoulder, @tight, @leg, @flank, @sleep, @awake, @workout_time, @allergy, @platin, @joint_problem, @suger_blood, @blood_problem, @surgery, @broken, @spinal, @hate_food, @status)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user_id", lbl_id.Text);
            try
            {
                data1 = File.ReadAllBytes(openFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_front", DbType.Binary, data1.Length);
            cmd.Parameters["@img_front"].Value = data1;

            try
            {
                data2 = File.ReadAllBytes(openFileDialog2.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_back", DbType.Binary, data2.Length);
            cmd.Parameters["@img_back"].Value = data2;

            try
            {
                data3 = File.ReadAllBytes(openFileDialog3.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_right", DbType.Binary, data3.Length);
            cmd.Parameters["@img_right"].Value = data3;

            try
            {
                data4 = File.ReadAllBytes(openFileDialog4.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_left", DbType.Binary, data4.Length);
            cmd.Parameters["@img_left"].Value = data4;

            /*@age, 
             * @height,
             * @weight, 
             * @blood, @arm
             * , @neck, @forearm, 
             * @chest, @back, @hip,
             * @shoulder, @tight, @leg, @flank,
             * @sleep, @awake, @workout_time, @allergy,
             * @platin, @joint_problem,
             * @suger_blood,
             * @blood_problem,
             * @surgery, @broken, @spinal, @hate_food, @status
             * */
            cmd.Parameters.AddWithValue("@age", txt_age.Text);
            cmd.Parameters.AddWithValue("@height", txt_height.Text);
            cmd.Parameters.AddWithValue("@weight", txt_weight.Text);
            cmd.Parameters.AddWithValue("@blood", txt_blood.Text);
            cmd.Parameters.AddWithValue("@arm", txt_arm.Text);
            cmd.Parameters.AddWithValue("@neck", txt_neck.Text);
            cmd.Parameters.AddWithValue("@forearm", txt_arm.Text);
            cmd.Parameters.AddWithValue("@chest", txt_chest.Text);
            cmd.Parameters.AddWithValue("@back", txt_back.Text);
            cmd.Parameters.AddWithValue("@hip", txt_hip.Text);
            cmd.Parameters.AddWithValue("@shoulder", txt_shoulder.Text);
            cmd.Parameters.AddWithValue("@tight", txt_tight.Text);
            cmd.Parameters.AddWithValue("@leg", txt_leg.Text);
            cmd.Parameters.AddWithValue("@flank", txt_flank.Text);
            cmd.Parameters.AddWithValue("@sleep", txt_sleep.Text);
            cmd.Parameters.AddWithValue("@awake", txt_awake.Text);
            cmd.Parameters.AddWithValue("@workout_time", txt_workout_time.Text);
            cmd.Parameters.AddWithValue("@allergy", txt_food_alergy.Text);
            cmd.Parameters.AddWithValue("@platin", txt_platin.Text);
            cmd.Parameters.AddWithValue("@joint_problem", txt_joint.Text);
            cmd.Parameters.AddWithValue("@suger_blood", txt_suger.Text);
            cmd.Parameters.AddWithValue("@blood_problem", txt_blood_problem.Text);
            cmd.Parameters.AddWithValue("@surgery", txt_surgery.Text);
            cmd.Parameters.AddWithValue("@broken", txt_broken.Text);
            cmd.Parameters.AddWithValue("@spinal", txt_back_problem.Text);
            cmd.Parameters.AddWithValue("@hate_food", txt_hate_food.Text);
            cmd.Parameters.AddWithValue("@status", 1);

            con.Open();
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("ثبت شد");
                RefreshDGV();
                AdjustColumns();
            }
            con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            byte[] data1 = null;
            byte[] data2 = null;
            byte[] data3 = null;
            byte[] data4 = null;
            SQLiteCommand cmd = new SQLiteCommand("update tbl_profile set img_front=@img_front, img_back=@img_back, img_right=@img_right, img_left=@img_left, age=@age, height=@height, weight=@weight, blood=@blood, arm=@arm, neck=@neck, forearm=@forearm, chest=@chest, back=@back, hip=@hip, shoulder=@shoulder, tight=@tight, leg=@leg, flank=@flank, sleep=@sleep, awake=@awake, workout_time=@workout_time, allergy=@allergy, platin=@platin, joint_problem=@joint_problem, suger_blood=@suger_blood, blood_problem=@blood_problem, surgery=@surgery, broken=@broken, spinal=@spinal, hate_food=@hate_food where id=@id", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", lbl_profile.Text);
            try
            {
                data1 = File.ReadAllBytes(openFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_front", DbType.Binary, data1.Length);
            cmd.Parameters["@img_front"].Value = data1;

            try
            {
                data2 = File.ReadAllBytes(openFileDialog2.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_back", DbType.Binary, data2.Length);
            cmd.Parameters["@img_back"].Value = data2;

            try
            {
                data3 = File.ReadAllBytes(openFileDialog3.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_right", DbType.Binary, data3.Length);
            cmd.Parameters["@img_right"].Value = data3;

            try
            {
                data4 = File.ReadAllBytes(openFileDialog4.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Add("@img_left", DbType.Binary, data4.Length);
            cmd.Parameters["@img_left"].Value = data4;

            /*@age, 
             * @height,
             * @weight, 
             * @blood, @arm
             * , @neck, @forearm, 
             * @chest, @back, @hip,
             * @shoulder, @tight, @leg, @flank,
             * @sleep, @awake, @workout_time, @allergy,
             * @platin, @joint_problem,
             * @suger_blood,
             * @blood_problem,
             * @surgery, @broken, @spinal, @hate_food, @status
             * */
            cmd.Parameters.AddWithValue("@age", txt_age.Text);
            cmd.Parameters.AddWithValue("@height", txt_height.Text);
            cmd.Parameters.AddWithValue("@weight", txt_weight.Text);
            cmd.Parameters.AddWithValue("@blood", txt_blood.Text);
            cmd.Parameters.AddWithValue("@arm", txt_arm.Text);
            cmd.Parameters.AddWithValue("@neck", txt_neck.Text);
            cmd.Parameters.AddWithValue("@forearm", txt_arm.Text);
            cmd.Parameters.AddWithValue("@chest", txt_chest.Text);
            cmd.Parameters.AddWithValue("@back", txt_back.Text);
            cmd.Parameters.AddWithValue("@hip", txt_hip.Text);
            cmd.Parameters.AddWithValue("@shoulder", txt_shoulder.Text);
            cmd.Parameters.AddWithValue("@tight", txt_tight.Text);
            cmd.Parameters.AddWithValue("@leg", txt_leg.Text);
            cmd.Parameters.AddWithValue("@flank", txt_flank.Text);
            cmd.Parameters.AddWithValue("@sleep", txt_sleep.Text);
            cmd.Parameters.AddWithValue("@awake", txt_awake.Text);
            cmd.Parameters.AddWithValue("@workout_time", txt_workout_time.Text);
            cmd.Parameters.AddWithValue("@allergy", txt_food_alergy.Text);
            cmd.Parameters.AddWithValue("@platin", txt_platin.Text);
            cmd.Parameters.AddWithValue("@joint_problem", txt_joint.Text);
            cmd.Parameters.AddWithValue("@suger_blood", txt_suger.Text);
            cmd.Parameters.AddWithValue("@blood_problem", txt_blood_problem.Text);
            cmd.Parameters.AddWithValue("@surgery", txt_surgery.Text);
            cmd.Parameters.AddWithValue("@broken", txt_broken.Text);
            cmd.Parameters.AddWithValue("@spinal", txt_back_problem.Text);
            cmd.Parameters.AddWithValue("@hate_food", txt_hate_food.Text);

            con.Open();
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("ویرایش شد");
                RefreshDGV();
                AdjustColumns();
            }
            con.Close();
        }

        private void dgv_profile_DoubleClick(object sender, EventArgs e)
        {
            lbl_profile.Text = dgv_profile.SelectedRows[0].Cells[0].Value.ToString();
            lbl_id.Text = dgv_profile.SelectedRows[0].Cells[1].Value.ToString();

            pic_front.BackgroundImageLayout = ImageLayout.Zoom;
            MemoryStream ms = new MemoryStream((byte[])(dgv_profile.Rows[dgv_profile.CurrentRow.Index].Cells[2].Value));
            pic_front.BackgroundImage = Image.FromStream(ms);

            pic_back.BackgroundImageLayout = ImageLayout.Zoom;
            MemoryStream ms1 = new MemoryStream((byte[])(dgv_profile.Rows[dgv_profile.CurrentRow.Index].Cells[3].Value));
            pic_back.BackgroundImage = Image.FromStream(ms1);

            pic_right.BackgroundImageLayout = ImageLayout.Zoom;
            MemoryStream ms2 = new MemoryStream((byte[])(dgv_profile.Rows[dgv_profile.CurrentRow.Index].Cells[4].Value));
            pic_right.BackgroundImage = Image.FromStream(ms2);

            pic_left.BackgroundImageLayout = ImageLayout.Zoom;
            MemoryStream ms3 = new MemoryStream((byte[])(dgv_profile.Rows[dgv_profile.CurrentRow.Index].Cells[5].Value));
            pic_left.BackgroundImage = Image.FromStream(ms3);

            txt_age.Text = dgv_profile.SelectedRows[0].Cells[6].Value.ToString();
            txt_height.Text = dgv_profile.SelectedRows[0].Cells[7].Value.ToString();
            txt_weight.Text = dgv_profile.SelectedRows[0].Cells[8].Value.ToString();
            txt_blood.Text = dgv_profile.SelectedRows[0].Cells[9].Value.ToString();
            txt_arm.Text = dgv_profile.SelectedRows[0].Cells[10].Value.ToString();
            txt_neck.Text = dgv_profile.SelectedRows[0].Cells[11].Value.ToString();
            txt_arm.Text = dgv_profile.SelectedRows[0].Cells[12].Value.ToString();
            txt_chest.Text = dgv_profile.SelectedRows[0].Cells[13].Value.ToString();
            txt_back.Text = dgv_profile.SelectedRows[0].Cells[14].Value.ToString();
            txt_hip.Text = dgv_profile.SelectedRows[0].Cells[15].Value.ToString();
            txt_shoulder.Text = dgv_profile.SelectedRows[0].Cells[16].Value.ToString();
            txt_tight.Text = dgv_profile.SelectedRows[0].Cells[17].Value.ToString();
            txt_leg.Text = dgv_profile.SelectedRows[0].Cells[18].Value.ToString();
            txt_flank.Text = dgv_profile.SelectedRows[0].Cells[19].Value.ToString();
            txt_sleep.Text = dgv_profile.SelectedRows[0].Cells[20].Value.ToString();
            txt_awake.Text = dgv_profile.SelectedRows[0].Cells[21].Value.ToString();
            txt_workout_time.Text = dgv_profile.SelectedRows[0].Cells[21].Value.ToString();
            txt_food_alergy.Text = dgv_profile.SelectedRows[0].Cells[22].Value.ToString();
            txt_platin.Text = dgv_profile.SelectedRows[0].Cells[23].Value.ToString();
            txt_joint.Text = dgv_profile.SelectedRows[0].Cells[24].Value.ToString();
            txt_suger.Text = dgv_profile.SelectedRows[0].Cells[25].Value.ToString();
            txt_blood_problem.Text = dgv_profile.SelectedRows[0].Cells[26].Value.ToString();
            txt_surgery.Text = dgv_profile.SelectedRows[0].Cells[27].Value.ToString();
            txt_broken.Text = dgv_profile.SelectedRows[0].Cells[28].Value.ToString();
            txt_back_problem.Text = dgv_profile.SelectedRows[0].Cells[29].Value.ToString();
            txt_hate_food.Text = dgv_profile.SelectedRows[0].Cells[30].Value.ToString();
        }

        private void dgv_profile_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgv_profile_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا پروفایل حدف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteCommand cmd = new SQLiteCommand("delete from tbl_profile where id = @id", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dgv_profile.SelectedRows[0].Cells[0].Value.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDGV();
                AdjustColumns();
                MessageBox.Show("پروفایل حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_plan_Click(object sender, EventArgs e)
        {
            frmPlan plan = new frmPlan();
            plan.lbl_profile_id.Text = lbl_profile.Text;
            plan.Show();
            this.Hide();
        }
    }
}
