using System;

namespace WorkHours.BL
{
    public sealed class Result_Block
    {
        public Result_Block(double hourPayment, double paymentCoef, double hoursOff)
        {
            if (hourPayment < 0)
            {
                throw new ArgumentException("hourPayment меньше нуля", nameof(hourPayment));
            }
            if (paymentCoef < 0)
            {
                throw new ArgumentException("paymentCoef меньше нуля", nameof(paymentCoef));
            }
            if (hoursOff < 0 || hoursOff > 24)
            {
                throw new ArgumentException("hoursOff некорректный", nameof(hoursOff));
            }

            _hourPayment = hourPayment;
            _paymentCoef = paymentCoef;
            _hoursOff = hoursOff;
        }

        /// <summary>
        /// Почасовая ставка
        /// </summary>
        private double _hourPayment;
        public double HourPayment
        {
            get => _hourPayment;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _hourPayment = value;
            }
        }

        /// <summary>
        /// Число, на которое умножается почасовая ставка
        /// </summary>
        private double _paymentCoef;
        public double PaymentCoef
        {
            get => _paymentCoef;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _paymentCoef = value;
            }
        }

        /// <summary>
        /// Уменьшение часов в предпраздничный день
        /// </summary>
        private double _hoursOff;
        public double HoursOff
        {
            get => _hoursOff;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 24)
                {
                    value = 24;
                }
                _hoursOff = value;
            }
        }

        /// <summary>
        /// Считает общее рабочее время в заданном промежутке
        /// </summary>
        /// <param name="dateTimeStart">Дата начала отсчета</param>
        /// <param name="dateTimeEnd">Дата конца отсчета</param>
        /// <param name="_holidays_Block">Ссылка на блок выходных</param>
        /// <param name="daysAmout">Кол-во дней в заданном промежутке</param>
        /// <returns>Общее количество часов в заданном промежутке</returns>
        public double CountHours(DateTime dateTimeStart, DateTime dateTimeEnd, Holidays_Block holidays_Block, Hours_Block hours_Block, out double payment)
        {
            if (holidays_Block == null)
            {
                throw new ArgumentNullException("Ссылка на блок выходных == null", nameof(holidays_Block));
            }
            if (hours_Block == null)
            {
                throw new ArgumentNullException("Ссылка на блок часов == null", nameof(hours_Block));
            }

            DayType[] dayTypes = GetDayTypes(dateTimeStart, dateTimeEnd, holidays_Block);
            double totalHours = GetTotalHours(dateTimeStart, dateTimeEnd, hours_Block, dayTypes);

            payment = countPayment(totalHours);
            return totalHours;
        }

        /// <summary>
        /// Получает типы дней в заданном промежутке
        /// </summary>
        /// <param name="dateTimeStart">День начала</param>
        /// <param name="dateTimeEnd">День конца</param>
        /// <param name="holidays_Block">Ссылка на блок выходных</param>
        /// <returns>Массив типов дней</returns>
        private DayType[] GetDayTypes(DateTime dateTimeStart, DateTime dateTimeEnd, Holidays_Block holidays_Block)
        {
            DayType[] types = new DayType[(int)(dateTimeEnd - dateTimeStart).TotalDays + 1];
            DateTime dateTimeNow = dateTimeStart;
            int id = 0;

            while (dateTimeNow <= dateTimeEnd)
            {
                if (holidays_Block.FindHoliday(dateTimeNow.Month, dateTimeNow.Day))
                {
                    types[id] = DayType.Holiday;
                    if (id > 0)
                    {
                        types[id - 1] = DayType.PreHoliday;
                    }
                }
                else
                {
                    types[id] = DayType.Work;
                }
                id += 1;
                dateTimeNow = dateTimeNow.AddDays(1);
            }
            return types;
        }

        private double GetTotalHours(DateTime dateTimeStart, DateTime dateTimeEnd, Hours_Block hours_Block, DayType[] dayTypes)
        {
            double totalHours = 0;
            DateTime dateTimeNow = dateTimeStart;
            int id = 0;

            while (dateTimeNow <= dateTimeEnd)
            {
                if (dayTypes[id] == DayType.Work)
                {
                    totalHours += hours_Block.DaysOfWeek[(int)dateTimeNow.DayOfWeek].GetTime();
                }
                else if (dayTypes[id] == DayType.PreHoliday)
                {
                    double result = hours_Block.DaysOfWeek[(int)dateTimeNow.DayOfWeek].GetTime() - _hoursOff;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    totalHours += result;
                }
                id += 1;
                dateTimeNow = dateTimeNow.AddDays(1);
            }
            return totalHours;
        }

        private double countPayment(double totalHours)
        {
            return _hourPayment * totalHours * _paymentCoef;
        }
    }
}
