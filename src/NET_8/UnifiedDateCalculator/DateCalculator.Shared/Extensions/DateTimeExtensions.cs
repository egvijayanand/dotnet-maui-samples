namespace DateCalculator.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime AddWeeks(this DateTime dateTime, int value)
            => dateTime.AddDays(value * 7);
    }
}
