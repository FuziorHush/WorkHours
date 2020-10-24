using System;

namespace WorkHours.BL
{
    [Serializable]
    public class Holiday
    {
        public string Name { get; set; }
        public int Mounth { get; set; }
        public int Day { get; set; }
        public bool Enabled { get; set; }

        public Holiday()
        {

        }

        public Holiday(string name, int mounth, int day, bool enabled)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название выходного пусто или null.", nameof(name));
            }
            if (mounth < 1 || mounth > 12)
            {
                throw new ArgumentException("Номер месяца может принимать только значения от 1 до 12.", nameof(mounth));
            }
            if (day < 1 || day > Holidays_Block.DaysOfMounths[mounth - 1])
            {
                throw new ArgumentException("Указан некорректный день для месяца " + mounth + ".", nameof(day));
            }

            Name = name;
            Mounth = mounth;
            Day = day;
            Enabled = enabled;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
