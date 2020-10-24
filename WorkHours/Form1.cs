using System;
using System.Drawing;
using System.Windows.Forms;
using WorkHours.BL;

namespace WorkHours
{
    public partial class Form1 : Form
    {
        private double _daysDifference;//Количество выбранных дней


        #region References
        private Holidays_Block _holidays_Block;
        private Hours_Block _hours_Block;
        private Result_Block _result_Block;
        #endregion


        #region Initialization
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _holidays_Block = new Holidays_Block();
            _hours_Block = new Hours_Block();
            _result_Block = new Result_Block(double.Parse(textBox_hourPayment.Text), double.Parse(textBox_coef.Text), double.Parse(textBox_hoursOff.Text));

            _initialize_CalendarBlock();
            _fillDataGrid();
        }

        /// <summary>
        /// Первичная настройка календарей
        /// </summary>
        private void _initialize_CalendarBlock()
        {
            DateTime dt = DateTime.Today;//Сегодня
            monthCalendar1.TodayDate = dt;//Сегодня - первый календарь
            dt = dt.AddDays(1);//Ко второму календарю прибавляется день
            monthCalendar2.TodayDate = dt;//Завтра - второй календарь

            label_start_calendar.Text = monthCalendar1.TodayDate.ToShortDateString();//Вывод даты под календарями для удобности
            label_end_calendar.Text = monthCalendar2.TodayDate.ToShortDateString();

            _checkSetData();
        }

        /// <summary>
        /// Первичная настройка и заполнение DataGrid
        /// </summary>
        private void _fillDataGrid()
        {
            dataGridView1.DataSource = _holidays_Block.LoadHolidays();
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[0].Width = 245;
            dataGridView1.Columns[1].HeaderText = "Мес.";
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].HeaderText = "День";
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].HeaderText = "Вкл.";
            dataGridView1.Columns[3].Width = 40;
        }
        #endregion


        #region Result_block
        private void button_count_Click(object sender, EventArgs e)
        {
            double payment;
            textBox_totaHours.Text =
                Math.Round(_result_Block.CountHours(monthCalendar1.TodayDate, monthCalendar2.TodayDate, _holidays_Block, _hours_Block, out payment), 2).ToString();
            textBox_allPayment.Text = payment.ToString();
        }

        private void textBox_hoursOff_Leave(object sender, EventArgs e)
        {
            try
            {
                double amout = double.Parse(textBox_hoursOff.Text);
                if (amout < 0)
                {
                    textBox_hoursOff.Text = "1,0";
                }
                if (amout > 24)
                {
                    textBox_hoursOff.Text = "1,0";
                }
                _result_Block.HoursOff = amout;
            }
            catch (Exception)
            {
                textBox_hoursOff.Text = "1,0";
            }
        }

        private void textBox_coef_Leave(object sender, EventArgs e)
        {
            try
            {
                double amout = double.Parse(textBox_coef.Text);
                if (amout < 0)
                {
                    textBox_coef.Text = "1,0";
                }
                _result_Block.PaymentCoef = amout;
            }
            catch (Exception)
            {
                textBox_coef.Text = "1,0";
            }
        }

        private void textBox_hourPayment_Leave(object sender, EventArgs e)
        {
            try
            {
                double amout = double.Parse(textBox_hourPayment.Text);
                if (amout < 0)
                {
                    textBox_hourPayment.Text = "0";
                }
                _result_Block.HourPayment = amout;
            }
            catch (Exception)
            {
                textBox_hourPayment.Text = "0";
            }
        }
        #endregion


        #region Date_block
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.TodayDate = e.End;
            label_start_calendar.Text = monthCalendar1.TodayDate.ToShortDateString();
            _checkSetData();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.TodayDate = e.End;
            label_end_calendar.Text = monthCalendar2.TodayDate.ToShortDateString();
            _checkSetData();
        }

        /// <summary>
        /// Проверяет даты, чтобы вторая была больше
        /// </summary>
        private void _checkSetData()
        {
            if (monthCalendar1.TodayDate <= monthCalendar2.TodayDate)
            {
                button_count.Enabled = true;//Активация кнопки рассчета
                _setAmoutOfSelectedDays();//Вычисление _daysDifference
                label_dataIsIncorrect.ForeColor = Color.Black;
                label_dataIsIncorrect.Text = "Количество выбранных дней включительно: " + _daysDifference;
            }
            else
            {
                button_count.Enabled = false;//Деактивация кнопки рассчета
                label_dataIsIncorrect.ForeColor = Color.Red;
                label_dataIsIncorrect.Text = "Дата конца не должна быть раньше даты начала";
            }
        }
        #endregion


        #region Hours_block
        private void Hr_sunday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_sunday, 0);
        }
        private void Mn_sunday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_sunday, 0);
        }

        private void Hr_monday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_monday, 1);
        }
        private void Mn_monday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_monday, 1);
        }

        private void Hr_tuesday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_tuesday, 2);
        }
        private void Mn_tuesday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_tuesday, 2);
        }

        private void Hr_wednesday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_wednesday, 3);
        }
        private void Mn_wednesday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_wednesday, 3);
        }

        private void Hr_thursday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_thursday, 4);
        }
        private void Mn_thursday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_thursday, 4);
        }

        private void Hr_friday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_friday, 5);
        }
        private void Mn_friday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_friday, 5);
        }

        private void Hr_saturday_Leave(object sender, EventArgs e)
        {
            _setHour(Hr_saturday, 6);
        }
        private void Mn_saturday_Leave(object sender, EventArgs e)
        {
            _setMinute(Mn_saturday, 6);
        }

        /// <summary>
        /// Проверяет значение часов в текстбоксе, и ставит в объект дня
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="id"></param>
        private void _setHour(TextBox textBox, int id)
        {
            try
            {
                double hours = double.Parse(textBox.Text);
                if (hours >= 0 && hours <= 24)
                {
                    _hours_Block.DaysOfWeek[id].Hours = hours;
                }
                else
                {
                    textBox.Text = "0";
                    _hours_Block.DaysOfWeek[id].Hours = 0;
                }
            }
            catch (Exception)
            {
                textBox.Text = "0";
                _hours_Block.DaysOfWeek[id].Hours = 0;
            }
        }

        /// <summary>
        /// Проверяет значение минут в текстбоксе, и ставит в объект дня
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="id"></param>
        private void _setMinute(TextBox textBox, int id)
        {
            try
            {
                double minutes = double.Parse(textBox.Text);
                if (minutes >= 0 && minutes <= 60)
                {
                    _hours_Block.DaysOfWeek[id].Minutes = minutes;
                }
                else
                {
                    textBox.Text = "0";
                    _hours_Block.DaysOfWeek[id].Minutes = 0;
                }
            }
            catch (ArgumentException)
            {
                textBox.Text = "0";
                _hours_Block.DaysOfWeek[id].Minutes = 0;
            }
        }
        #endregion


        #region Holidays_block
        private void button_DeleteChoosenDay_Click(object sender, EventArgs e)
        {
            _holidays_Block.DeleteHoliday(dataGridView1.SelectedCells[0].RowIndex);
            _holidays_Block.SaveHolidays();
            dataGridView1.DataSource = _holidays_Block.LoadHolidays();
        }

        private void textBox_add_mnt_Leave(object sender, EventArgs e)
        {
            try
            {
                int amout = int.Parse(textBox_add_mnt.Text);
                if (amout >= 1 && amout <= 12)
                {
                    //информация и должна просто остаться в текстбоксе
                }
                else
                {
                    textBox_add_mnt.Text = "1";
                }
            }
            catch (Exception)
            {
                textBox_add_mnt.Text = "1";
            }
        }

        private void textBox_add_day_Leave(object sender, EventArgs e)
        {
            try
            {
                int amout = int.Parse(textBox_add_day.Text);
                if (amout >= 1 && amout <= Holidays_Block.DaysOfMounths[int.Parse(textBox_add_mnt.Text) - 1])
                {
                    //информация и должна просто остаться в текстбоксе
                }
                else
                {
                    textBox_add_day.Text = "1";
                }
            }
            catch (Exception)
            {
                textBox_add_day.Text = "1";
            }
        }

        /// <summary>
        /// Проверка введенного названия нового выходного
        /// </summary>
        private void textBox_nameOfNewHoliday_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nameOfNewHoliday.Text)) {
                textBox_nameOfNewHoliday.Text = "Новый выходной";
            }
        }

        private void button_addHoliday_Click(object sender, EventArgs e)
        {
            _holidays_Block.AddHoliday(textBox_nameOfNewHoliday.Text, int.Parse(textBox_add_mnt.Text), int.Parse(textBox_add_day.Text));
            _holidays_Block.SaveHolidays();
            dataGridView1.DataSource = _holidays_Block.LoadHolidays();//Обновление DataGrid
        }
        #endregion


        #region Menu_info
        private void info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showInfoWindow();
        }

        private void _showInfoWindow()
        {
            string message = "В левом календаре выберите дату, с которой начнется отсчет.\n" +
    "В правом календаре выберите дату, на которй отсчет будет закончен.\n" +
    "Введите количество часов и минут в блоке 'Рабочие часы'.\n" +
    "Нажмите кнопку 'Рассчет'. Результат будет представлен под кнопкой.\n" +
    "\n" +
    "В таблице представлен список выходных дней. Они не будут учитываться при рассчете, если у них стоит маркер в таблице 'Вкл.'\n" +
    "Чтобы добавить выходной день, введите название, номер месяца и день.\n" +
    "Чтобы удалить выходной день из списка, выберите его и нажмите соответствующую кнопку";
            string caption = "Информация";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }
        #endregion


        /// <summary>
        /// Вычисляет и устанавливает количество дней в заданном промежутке
        /// </summary>
        private void _setAmoutOfSelectedDays()
        {
            _daysDifference = (monthCalendar2.TodayDate - monthCalendar1.TodayDate).TotalDays + 1;
        }

        /// <summary>
        /// Список праздников сохраняется при закрытии программы
        /// </summary>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _holidays_Block.SaveHolidays();
        }
    }
}
