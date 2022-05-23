using DateCalculator.Models;

namespace DateCalculator.Extensions
{
    public static class IntExtensions
    {
        public static string InWords(this int num, TimeUnit unit)
        {
            return num <= 0
                ? string.Empty
                : unit switch
                {
                    TimeUnit.Year => num > 1 ? $"{num} years" : "1 year",
                    TimeUnit.Month => num > 1 ? $"{num} months" : "1 month",
                    TimeUnit.Week => num > 1 ? $"{num} weeks" : "1 week",
                    TimeUnit.Day => num > 1 ? $"{num} days" : "1 day",
                    _ => string.Empty,
                };
        }
    }
}
