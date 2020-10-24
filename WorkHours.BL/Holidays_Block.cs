using System;
using System.Collections.Generic;

namespace WorkHours.BL
{
    public sealed class Holidays_Block
    {
        public readonly static double[] DaysOfMounths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public List<Holiday> Holidays;

        public void DeleteHoliday(int index)
        {
            Holidays.RemoveAt(index);
        }

        public void AddHoliday(string name, int mounth, int day)
        {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentNullException("Название выходного пусто или null.", nameof(name));
            }
            if (mounth < 1 || mounth > 12)
            {
                throw new ArgumentException("Номер месяца может принимать только значения от 1 до 12.", nameof(mounth));
            }
            if (day < 1 || day > DaysOfMounths[mounth - 1])
            {
                throw new ArgumentException("Указан некорректный день для месяца " + mounth + ".", nameof(day));
            }

            Holidays.Add(new Holiday(name, mounth, day, true));
        }

        public void SaveHolidays()
        {
            Holidays_File_Manager.Save(Holidays);
        }

        public List<Holiday> LoadHolidays()
        {
            Holidays = Holidays_File_Manager.Load();
            return Holidays;
        }

        /// <summary>
        /// Ищет день в списке
        /// </summary>
        public bool FindHoliday(int mounth, int day) {
            for (int i = 0; i < Holidays.Count; i++) {
                if (Holidays[i].Enabled) {
                    if (mounth == Holidays[i].Mounth) {
                        if (day == Holidays[i].Day) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
