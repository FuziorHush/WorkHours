namespace WorkHours.BL
{
    /// <summary>
    /// Блок рабочих часов для каждого дня недели
    /// </summary>
    public sealed class Hours_Block
    {
        public DayOfWeekTime[] DaysOfWeek = new DayOfWeekTime[7];

        public Hours_Block()
        {
            for (int i = 0; i < DaysOfWeek.Length; i++)
            {
                DaysOfWeek[i] = new DayOfWeekTime();
            }
        }
    }
}
