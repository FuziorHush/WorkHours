namespace WorkHours
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hr_monday = new System.Windows.Forms.TextBox();
            this.Hr_tuesday = new System.Windows.Forms.TextBox();
            this.Hr_wednesday = new System.Windows.Forms.TextBox();
            this.Hr_thursday = new System.Windows.Forms.TextBox();
            this.Hr_friday = new System.Windows.Forms.TextBox();
            this.Hr_saturday = new System.Windows.Forms.TextBox();
            this.Hr_sunday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Mn_monday = new System.Windows.Forms.TextBox();
            this.Mn_tuesday = new System.Windows.Forms.TextBox();
            this.Mn_wednesday = new System.Windows.Forms.TextBox();
            this.Mn_thursday = new System.Windows.Forms.TextBox();
            this.Mn_friday = new System.Windows.Forms.TextBox();
            this.Mn_saturday = new System.Windows.Forms.TextBox();
            this.Mn_sunday = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_end_calendar = new System.Windows.Forms.Label();
            this.label_start_calendar = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_dataIsIncorrect = new System.Windows.Forms.Label();
            this.button_count = new System.Windows.Forms.Button();
            this.textBox_totaHours = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_add_mnt = new System.Windows.Forms.TextBox();
            this.textBox_add_day = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_nameOfNewHoliday = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_addHoliday = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_allPayment = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_hourPayment = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_coef = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_hoursOff = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hr_monday
            // 
            this.Hr_monday.Location = new System.Drawing.Point(92, 55);
            this.Hr_monday.Name = "Hr_monday";
            this.Hr_monday.Size = new System.Drawing.Size(33, 20);
            this.Hr_monday.TabIndex = 0;
            this.Hr_monday.Text = "0";
            this.Hr_monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_monday.Leave += new System.EventHandler(this.Hr_monday_Leave);
            // 
            // Hr_tuesday
            // 
            this.Hr_tuesday.Location = new System.Drawing.Point(92, 82);
            this.Hr_tuesday.Name = "Hr_tuesday";
            this.Hr_tuesday.Size = new System.Drawing.Size(33, 20);
            this.Hr_tuesday.TabIndex = 1;
            this.Hr_tuesday.Text = "0";
            this.Hr_tuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_tuesday.Leave += new System.EventHandler(this.Hr_tuesday_Leave);
            // 
            // Hr_wednesday
            // 
            this.Hr_wednesday.Location = new System.Drawing.Point(92, 109);
            this.Hr_wednesday.Name = "Hr_wednesday";
            this.Hr_wednesday.Size = new System.Drawing.Size(33, 20);
            this.Hr_wednesday.TabIndex = 2;
            this.Hr_wednesday.Text = "0";
            this.Hr_wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_wednesday.Leave += new System.EventHandler(this.Hr_wednesday_Leave);
            // 
            // Hr_thursday
            // 
            this.Hr_thursday.Location = new System.Drawing.Point(92, 136);
            this.Hr_thursday.Name = "Hr_thursday";
            this.Hr_thursday.Size = new System.Drawing.Size(33, 20);
            this.Hr_thursday.TabIndex = 3;
            this.Hr_thursday.Text = "0";
            this.Hr_thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_thursday.Leave += new System.EventHandler(this.Hr_thursday_Leave);
            // 
            // Hr_friday
            // 
            this.Hr_friday.Location = new System.Drawing.Point(92, 163);
            this.Hr_friday.Name = "Hr_friday";
            this.Hr_friday.Size = new System.Drawing.Size(33, 20);
            this.Hr_friday.TabIndex = 4;
            this.Hr_friday.Text = "0";
            this.Hr_friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_friday.Leave += new System.EventHandler(this.Hr_friday_Leave);
            // 
            // Hr_saturday
            // 
            this.Hr_saturday.Location = new System.Drawing.Point(92, 190);
            this.Hr_saturday.Name = "Hr_saturday";
            this.Hr_saturday.Size = new System.Drawing.Size(33, 20);
            this.Hr_saturday.TabIndex = 5;
            this.Hr_saturday.Text = "0";
            this.Hr_saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_saturday.Leave += new System.EventHandler(this.Hr_saturday_Leave);
            // 
            // Hr_sunday
            // 
            this.Hr_sunday.Location = new System.Drawing.Point(92, 217);
            this.Hr_sunday.Name = "Hr_sunday";
            this.Hr_sunday.Size = new System.Drawing.Size(33, 20);
            this.Hr_sunday.TabIndex = 6;
            this.Hr_sunday.Text = "0";
            this.Hr_sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hr_sunday.Leave += new System.EventHandler(this.Hr_sunday_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(131, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(131, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(131, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(131, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(131, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // Mn_monday
            // 
            this.Mn_monday.Location = new System.Drawing.Point(148, 55);
            this.Mn_monday.Name = "Mn_monday";
            this.Mn_monday.Size = new System.Drawing.Size(33, 20);
            this.Mn_monday.TabIndex = 14;
            this.Mn_monday.Text = "0";
            this.Mn_monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_monday.Leave += new System.EventHandler(this.Mn_monday_Leave);
            // 
            // Mn_tuesday
            // 
            this.Mn_tuesday.Location = new System.Drawing.Point(148, 82);
            this.Mn_tuesday.Name = "Mn_tuesday";
            this.Mn_tuesday.Size = new System.Drawing.Size(33, 20);
            this.Mn_tuesday.TabIndex = 15;
            this.Mn_tuesday.Text = "0";
            this.Mn_tuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_tuesday.Leave += new System.EventHandler(this.Mn_tuesday_Leave);
            // 
            // Mn_wednesday
            // 
            this.Mn_wednesday.Location = new System.Drawing.Point(148, 109);
            this.Mn_wednesday.Name = "Mn_wednesday";
            this.Mn_wednesday.Size = new System.Drawing.Size(33, 20);
            this.Mn_wednesday.TabIndex = 16;
            this.Mn_wednesday.Text = "0";
            this.Mn_wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_wednesday.Leave += new System.EventHandler(this.Mn_wednesday_Leave);
            // 
            // Mn_thursday
            // 
            this.Mn_thursday.Location = new System.Drawing.Point(148, 136);
            this.Mn_thursday.Name = "Mn_thursday";
            this.Mn_thursday.Size = new System.Drawing.Size(33, 20);
            this.Mn_thursday.TabIndex = 17;
            this.Mn_thursday.Text = "0";
            this.Mn_thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_thursday.Leave += new System.EventHandler(this.Mn_thursday_Leave);
            // 
            // Mn_friday
            // 
            this.Mn_friday.Location = new System.Drawing.Point(148, 163);
            this.Mn_friday.Name = "Mn_friday";
            this.Mn_friday.Size = new System.Drawing.Size(33, 20);
            this.Mn_friday.TabIndex = 18;
            this.Mn_friday.Text = "0";
            this.Mn_friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_friday.Leave += new System.EventHandler(this.Mn_friday_Leave);
            // 
            // Mn_saturday
            // 
            this.Mn_saturday.Location = new System.Drawing.Point(148, 190);
            this.Mn_saturday.Name = "Mn_saturday";
            this.Mn_saturday.Size = new System.Drawing.Size(33, 20);
            this.Mn_saturday.TabIndex = 19;
            this.Mn_saturday.Text = "0";
            this.Mn_saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_saturday.Leave += new System.EventHandler(this.Mn_saturday_Leave);
            // 
            // Mn_sunday
            // 
            this.Mn_sunday.Location = new System.Drawing.Point(148, 217);
            this.Mn_sunday.Name = "Mn_sunday";
            this.Mn_sunday.Size = new System.Drawing.Size(33, 20);
            this.Mn_sunday.TabIndex = 20;
            this.Mn_sunday.Text = "0";
            this.Mn_sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mn_sunday.Leave += new System.EventHandler(this.Mn_sunday_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Mn_saturday);
            this.groupBox1.Controls.Add(this.Mn_sunday);
            this.groupBox1.Controls.Add(this.Hr_monday);
            this.groupBox1.Controls.Add(this.Hr_tuesday);
            this.groupBox1.Controls.Add(this.Mn_friday);
            this.groupBox1.Controls.Add(this.Hr_wednesday);
            this.groupBox1.Controls.Add(this.Mn_thursday);
            this.groupBox1.Controls.Add(this.Hr_thursday);
            this.groupBox1.Controls.Add(this.Mn_wednesday);
            this.groupBox1.Controls.Add(this.Hr_friday);
            this.groupBox1.Controls.Add(this.Mn_tuesday);
            this.groupBox1.Controls.Add(this.Hr_saturday);
            this.groupBox1.Controls.Add(this.Mn_monday);
            this.groupBox1.Controls.Add(this.Hr_sunday);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(376, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 246);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(65, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Рабочие часы";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "мм";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "чч";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Воскресенье";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Суббота";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Пятница";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Четверг";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Среда";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Вторник";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Понедельник";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 48);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 22;
            this.monthCalendar1.TodayDate = new System.DateTime(2020, 7, 4, 0, 0, 0, 0);
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(182, 48);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowToday = false;
            this.monthCalendar2.ShowTodayCircle = false;
            this.monthCalendar2.TabIndex = 23;
            this.monthCalendar2.TodayDate = new System.DateTime(2020, 7, 4, 0, 0, 0, 0);
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label_end_calendar);
            this.groupBox2.Controls.Add(this.label_start_calendar);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label_dataIsIncorrect);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 246);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label_end_calendar
            // 
            this.label_end_calendar.AutoSize = true;
            this.label_end_calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_end_calendar.Location = new System.Drawing.Point(224, 207);
            this.label_end_calendar.Name = "label_end_calendar";
            this.label_end_calendar.Size = new System.Drawing.Size(64, 13);
            this.label_end_calendar.TabIndex = 29;
            this.label_end_calendar.Text = "00.0.0000";
            this.label_end_calendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_start_calendar
            // 
            this.label_start_calendar.AutoSize = true;
            this.label_start_calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start_calendar.Location = new System.Drawing.Point(52, 207);
            this.label_start_calendar.Name = "label_start_calendar";
            this.label_start_calendar.Size = new System.Drawing.Size(64, 13);
            this.label_start_calendar.TabIndex = 28;
            this.label_start_calendar.Text = "00.0.0000";
            this.label_start_calendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(224, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Конец отсчета";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Начало отсчета";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(163, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Даты";
            // 
            // label_dataIsIncorrect
            // 
            this.label_dataIsIncorrect.AutoSize = true;
            this.label_dataIsIncorrect.ForeColor = System.Drawing.Color.Red;
            this.label_dataIsIncorrect.Location = new System.Drawing.Point(64, 224);
            this.label_dataIsIncorrect.Name = "label_dataIsIncorrect";
            this.label_dataIsIncorrect.Size = new System.Drawing.Size(257, 13);
            this.label_dataIsIncorrect.TabIndex = 24;
            this.label_dataIsIncorrect.Text = "Дата конца не должна быть раньше даты начала";
            // 
            // button_count
            // 
            this.button_count.Location = new System.Drawing.Point(765, 27);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(121, 41);
            this.button_count.TabIndex = 25;
            this.button_count.Text = "Рассчет";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // textBox_totaHours
            // 
            this.textBox_totaHours.Location = new System.Drawing.Point(789, 100);
            this.textBox_totaHours.Name = "textBox_totaHours";
            this.textBox_totaHours.ReadOnly = true;
            this.textBox_totaHours.Size = new System.Drawing.Size(97, 20);
            this.textBox_totaHours.TabIndex = 26;
            this.textBox_totaHours.Text = "Кол-во часов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 254);
            this.dataGridView1.TabIndex = 28;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // info_ToolStripMenuItem
            // 
            this.info_ToolStripMenuItem.Name = "info_ToolStripMenuItem";
            this.info_ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.info_ToolStripMenuItem.Text = "Справка";
            this.info_ToolStripMenuItem.Click += new System.EventHandler(this.info_ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(458, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Удалить выбранный выходной";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_DeleteChoosenDay_Click);
            // 
            // textBox_add_mnt
            // 
            this.textBox_add_mnt.Location = new System.Drawing.Point(10, 98);
            this.textBox_add_mnt.Name = "textBox_add_mnt";
            this.textBox_add_mnt.Size = new System.Drawing.Size(43, 20);
            this.textBox_add_mnt.TabIndex = 31;
            this.textBox_add_mnt.Text = "1";
            this.textBox_add_mnt.Leave += new System.EventHandler(this.textBox_add_mnt_Leave);
            // 
            // textBox_add_day
            // 
            this.textBox_add_day.Location = new System.Drawing.Point(59, 98);
            this.textBox_add_day.Name = "textBox_add_day";
            this.textBox_add_day.Size = new System.Drawing.Size(43, 20);
            this.textBox_add_day.TabIndex = 32;
            this.textBox_add_day.Text = "1";
            this.textBox_add_day.Leave += new System.EventHandler(this.textBox_add_day_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "мес.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(61, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "день";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Название";
            // 
            // textBox_nameOfNewHoliday
            // 
            this.textBox_nameOfNewHoliday.Location = new System.Drawing.Point(10, 50);
            this.textBox_nameOfNewHoliday.Name = "textBox_nameOfNewHoliday";
            this.textBox_nameOfNewHoliday.Size = new System.Drawing.Size(241, 20);
            this.textBox_nameOfNewHoliday.TabIndex = 36;
            this.textBox_nameOfNewHoliday.Leave += new System.EventHandler(this.textBox_nameOfNewHoliday_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_addHoliday);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.textBox_add_day);
            this.groupBox3.Controls.Add(this.textBox_nameOfNewHoliday);
            this.groupBox3.Controls.Add(this.textBox_add_mnt);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(458, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 129);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // button_addHoliday
            // 
            this.button_addHoliday.Location = new System.Drawing.Point(138, 95);
            this.button_addHoliday.Name = "button_addHoliday";
            this.button_addHoliday.Size = new System.Drawing.Size(75, 23);
            this.button_addHoliday.TabIndex = 38;
            this.button_addHoliday.Text = "Добавить";
            this.button_addHoliday.UseVisualStyleBackColor = true;
            this.button_addHoliday.Click += new System.EventHandler(this.button_addHoliday_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(72, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "Добавить выходной";
            // 
            // textBox_allPayment
            // 
            this.textBox_allPayment.Location = new System.Drawing.Point(789, 151);
            this.textBox_allPayment.Name = "textBox_allPayment";
            this.textBox_allPayment.ReadOnly = true;
            this.textBox_allPayment.Size = new System.Drawing.Size(97, 20);
            this.textBox_allPayment.TabIndex = 38;
            this.textBox_allPayment.Text = "Общая выплата";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(786, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "Кол-во часов";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(786, 135);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Общая выплата";
            // 
            // textBox_hourPayment
            // 
            this.textBox_hourPayment.Location = new System.Drawing.Point(17, 43);
            this.textBox_hourPayment.Name = "textBox_hourPayment";
            this.textBox_hourPayment.Size = new System.Drawing.Size(79, 20);
            this.textBox_hourPayment.TabIndex = 41;
            this.textBox_hourPayment.Text = "0";
            this.textBox_hourPayment.Leave += new System.EventHandler(this.textBox_hourPayment_Leave);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 27);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 13);
            this.label27.TabIndex = 42;
            this.label27.Text = "Почасовая ставка";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(115, 13);
            this.label28.TabIndex = 43;
            this.label28.Text = "Коэффициент ставки";
            // 
            // textBox_coef
            // 
            this.textBox_coef.Location = new System.Drawing.Point(17, 97);
            this.textBox_coef.Name = "textBox_coef";
            this.textBox_coef.Size = new System.Drawing.Size(79, 20);
            this.textBox_coef.TabIndex = 44;
            this.textBox_coef.Text = "1,0";
            this.textBox_coef.Leave += new System.EventHandler(this.textBox_coef_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_hoursOff);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.textBox_coef);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.textBox_hourPayment);
            this.groupBox4.Location = new System.Drawing.Point(575, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 246);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // textBox_hoursOff
            // 
            this.textBox_hoursOff.Location = new System.Drawing.Point(17, 169);
            this.textBox_hoursOff.Name = "textBox_hoursOff";
            this.textBox_hoursOff.Size = new System.Drawing.Size(79, 20);
            this.textBox_hoursOff.TabIndex = 46;
            this.textBox_hoursOff.Text = "1,0";
            this.textBox_hoursOff.Leave += new System.EventHandler(this.textBox_hoursOff_Leave);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 139);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(152, 26);
            this.label29.TabIndex = 45;
            this.label29.Text = "Уменьшить кол-во часов\r\n в предпраздничный день на\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 545);
            this.Controls.Add(this.textBox_totaHours);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_allPayment);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет рабочих часов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hr_monday;
        private System.Windows.Forms.TextBox Hr_tuesday;
        private System.Windows.Forms.TextBox Hr_wednesday;
        private System.Windows.Forms.TextBox Hr_thursday;
        private System.Windows.Forms.TextBox Hr_friday;
        private System.Windows.Forms.TextBox Hr_saturday;
        private System.Windows.Forms.TextBox Hr_sunday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mn_monday;
        private System.Windows.Forms.TextBox Mn_tuesday;
        private System.Windows.Forms.TextBox Mn_wednesday;
        private System.Windows.Forms.TextBox Mn_thursday;
        private System.Windows.Forms.TextBox Mn_friday;
        private System.Windows.Forms.TextBox Mn_saturday;
        private System.Windows.Forms.TextBox Mn_sunday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_dataIsIncorrect;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_end_calendar;
        private System.Windows.Forms.Label label_start_calendar;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.TextBox textBox_totaHours;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_add_mnt;
        private System.Windows.Forms.TextBox textBox_add_day;
        private System.Windows.Forms.ToolStripMenuItem info_ToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_nameOfNewHoliday;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_addHoliday;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_allPayment;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_hourPayment;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_coef;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_hoursOff;
        private System.Windows.Forms.Label label29;
    }
}

