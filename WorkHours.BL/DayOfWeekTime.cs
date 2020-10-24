namespace WorkHours.BL
{
    /// <summary>
    /// Рабочее время для каждого дня недели
    /// </summary>
    public sealed class DayOfWeekTime
    {
        public double Hours { get; set; }
        public double Minutes { get; set; }

        public double GetTime() {
            return Hours + Minutes / 60;
        }
    }
}
