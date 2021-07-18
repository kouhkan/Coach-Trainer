
namespace Trainer
{
    partial class frmPlan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlan));
            this.txt_weight = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_day = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_workout = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_plan_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_workout_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_workout = new System.Windows.Forms.DataGridView();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_system = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_rests = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sets = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_workout = new System.Windows.Forms.PictureBox();
            this.lbl_profile_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_plan = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.report1 = new FastReport.Report();
            this.report2 = new FastReport.Report();
            this.report3 = new FastReport.Report();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_workout)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_weight
            // 
            this.txt_weight.Font = new System.Drawing.Font("IRTitr", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.FormattingEnabled = true;
            this.txt_weight.Items.AddRange(new object[] {
            "افزایش در هر ست",
            "کاهش در هر ست",
            "ثابت در هر ست",
            "افزایش و ثابت در هر ست"});
            this.txt_weight.Location = new System.Drawing.Point(490, 406);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(178, 31);
            this.txt_weight.TabIndex = 82;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(1037, 406);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(200, 96);
            this.txt_description.TabIndex = 73;
            this.txt_description.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1243, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 29);
            this.label14.TabIndex = 72;
            this.label14.Text = "توضیحات:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(674, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 29);
            this.label18.TabIndex = 43;
            this.label18.Text = "وزن:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_day);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_workout);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbl_plan_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_workout_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgv_workout);
            this.groupBox1.Controls.Add(this.txt_weight);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_tempo);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_system);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_rests);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_count);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_sets);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pic_workout);
            this.groupBox1.Controls.Add(this.lbl_profile_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("IRTitr", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1342, 515);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_day
            // 
            this.txt_day.Font = new System.Drawing.Font("IRTitr", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_day.FormattingEnabled = true;
            this.txt_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.txt_day.Location = new System.Drawing.Point(490, 454);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(178, 31);
            this.txt_day.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 90;
            this.label5.Text = "روز:";
            // 
            // lbl_workout
            // 
            this.lbl_workout.Location = new System.Drawing.Point(1094, 323);
            this.lbl_workout.Name = "lbl_workout";
            this.lbl_workout.Size = new System.Drawing.Size(143, 29);
            this.lbl_workout.TabIndex = 89;
            this.lbl_workout.Text = "-";
            this.lbl_workout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1238, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 29);
            this.label15.TabIndex = 88;
            this.label15.Text = "اسم حرکت:";
            // 
            // lbl_plan_id
            // 
            this.lbl_plan_id.Location = new System.Drawing.Point(196, 262);
            this.lbl_plan_id.Name = "lbl_plan_id";
            this.lbl_plan_id.Size = new System.Drawing.Size(95, 29);
            this.lbl_plan_id.TabIndex = 87;
            this.lbl_plan_id.Text = "-";
            this.lbl_plan_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 29);
            this.label8.TabIndex = 86;
            this.label8.Text = "شناسه:";
            // 
            // lbl_workout_id
            // 
            this.lbl_workout_id.Location = new System.Drawing.Point(490, 262);
            this.lbl_workout_id.Name = "lbl_workout_id";
            this.lbl_workout_id.Size = new System.Drawing.Size(95, 29);
            this.lbl_workout_id.TabIndex = 85;
            this.lbl_workout_id.Text = "-";
            this.lbl_workout_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 84;
            this.label6.Text = "شناسه حرکت:";
            // 
            // dgv_workout
            // 
            this.dgv_workout.AllowUserToAddRows = false;
            this.dgv_workout.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_workout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_workout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_workout.Location = new System.Drawing.Point(12, 22);
            this.dgv_workout.MultiSelect = false;
            this.dgv_workout.Name = "dgv_workout";
            this.dgv_workout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_workout.RowHeadersWidth = 51;
            this.dgv_workout.RowTemplate.Height = 24;
            this.dgv_workout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_workout.Size = new System.Drawing.Size(1324, 218);
            this.dgv_workout.TabIndex = 83;
            this.dgv_workout.DoubleClick += new System.EventHandler(this.dgv_workout_DoubleClick);
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(12, 319);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tempo.Size = new System.Drawing.Size(261, 37);
            this.txt_tempo.TabIndex = 66;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(290, 323);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 29);
            this.label29.TabIndex = 65;
            this.label29.Text = "تمپو:";
            // 
            // txt_system
            // 
            this.txt_system.Location = new System.Drawing.Point(12, 369);
            this.txt_system.Name = "txt_system";
            this.txt_system.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_system.Size = new System.Drawing.Size(394, 37);
            this.txt_system.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 29);
            this.label12.TabIndex = 31;
            this.label12.Text = "سیستم:";
            // 
            // txt_rests
            // 
            this.txt_rests.Location = new System.Drawing.Point(342, 319);
            this.txt_rests.Name = "txt_rests";
            this.txt_rests.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_rests.Size = new System.Drawing.Size(246, 37);
            this.txt_rests.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "استراحت:";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(674, 319);
            this.txt_count.Name = "txt_count";
            this.txt_count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_count.Size = new System.Drawing.Size(192, 37);
            this.txt_count.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(872, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "تعداد:";
            // 
            // txt_sets
            // 
            this.txt_sets.Location = new System.Drawing.Point(933, 319);
            this.txt_sets.Name = "txt_sets";
            this.txt_sets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_sets.Size = new System.Drawing.Size(83, 37);
            this.txt_sets.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1022, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "ست‌ها:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "تصویر حرکت:";
            // 
            // pic_workout
            // 
            this.pic_workout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_workout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_workout.Location = new System.Drawing.Point(727, 409);
            this.pic_workout.Name = "pic_workout";
            this.pic_workout.Size = new System.Drawing.Size(201, 88);
            this.pic_workout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_workout.TabIndex = 17;
            this.pic_workout.TabStop = false;
            // 
            // lbl_profile_id
            // 
            this.lbl_profile_id.Location = new System.Drawing.Point(763, 262);
            this.lbl_profile_id.Name = "lbl_profile_id";
            this.lbl_profile_id.Size = new System.Drawing.Size(95, 29);
            this.lbl_profile_id.TabIndex = 16;
            this.lbl_profile_id.Text = "-";
            this.lbl_profile_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "شناسه پروفایل:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Location = new System.Drawing.Point(12, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 85);
            this.panel1.TabIndex = 14;
            // 
            // btn_export
            // 
            this.btn_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export.Font = new System.Drawing.Font("IRTitr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Image = global::Trainer.Properties.Resources._29262_export_icon;
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_export.Location = new System.Drawing.Point(14, 14);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(151, 55);
            this.btn_export.TabIndex = 13;
            this.btn_export.Text = "خروجی";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("IRTitr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = global::Trainer.Properties.Resources._2530835_compose_create_edit_edit_file_office_icon__1_;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.Location = new System.Drawing.Point(171, 14);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(175, 55);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "ویرایش اطلاعات";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.Font = new System.Drawing.Font("IRTitr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Image = global::Trainer.Properties.Resources._1891021_approved_check_checkbox_checkmark_confirm_icon__4_;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.Location = new System.Drawing.Point(352, 14);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(98, 55);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "ثبت ";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1015, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(196, 37);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1217, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "جستجو حرکت:";
            // 
            // dgv_plan
            // 
            this.dgv_plan.AllowUserToAddRows = false;
            this.dgv_plan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_plan.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_plan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_plan.Location = new System.Drawing.Point(0, 521);
            this.dgv_plan.MultiSelect = false;
            this.dgv_plan.Name = "dgv_plan";
            this.dgv_plan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_plan.RowHeadersWidth = 51;
            this.dgv_plan.RowTemplate.Height = 24;
            this.dgv_plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_plan.Size = new System.Drawing.Size(1342, 238);
            this.dgv_plan.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletemenu,
            this.toolStripSeparator1,
            this.editmenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 58);
            // 
            // deletemenu
            // 
            this.deletemenu.Name = "deletemenu";
            this.deletemenu.Size = new System.Drawing.Size(124, 24);
            this.deletemenu.Text = "حذف";
            this.deletemenu.Click += new System.EventHandler(this.deletemenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // editmenu
            // 
            this.editmenu.Name = "editmenu";
            this.editmenu.Size = new System.Drawing.Size(124, 24);
            this.editmenu.Text = "ویرایش";
            this.editmenu.Click += new System.EventHandler(this.editmenu_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            // 
            // report2
            // 
            this.report2.NeedRefresh = false;
            this.report2.ReportResourceString = resources.GetString("report2.ReportResourceString");
            this.report2.Tag = null;
            // 
            // report3
            // 
            this.report3.NeedRefresh = false;
            this.report3.ReportResourceString = resources.GetString("report3.ReportResourceString");
            this.report3.Tag = null;
            // 
            // frmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_plan);
            this.Font = new System.Drawing.Font("IRTitr", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوشتن برنامه";
            this.Load += new System.EventHandler(this.frmPlan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_workout)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_weight;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_system;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_rests;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_workout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_plan;
        private System.Windows.Forms.Label lbl_workout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_plan_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_workout_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_workout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private FastReport.Report report1;
        private System.Windows.Forms.ComboBox txt_day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem deletemenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editmenu;
        public System.Windows.Forms.Label lbl_profile_id;
        private FastReport.Report report2;
        private FastReport.Report report3;
    }
}