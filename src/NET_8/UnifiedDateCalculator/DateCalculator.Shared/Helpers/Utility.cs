using DateCalculator.Extensions;
using DateCalculator.Models;

namespace DateCalculator.Helpers
{
    public static class Utility
    {
        public static string DateDiff(DateTime startDate, DateTime endDate)
        {
            var diff = endDate - startDate;

            if (diff == TimeSpan.Zero)
            {
                return "Same dates";
            }
            else
            {
                var list = new List<string>();

                int noOfYears = endDate.Year - startDate.Year;
                int noOfMonths = 0;
                int noOfDays = 0;
                int noOfWeeks = 0;
                int leftoverDays = 0;

                var cutoffDate = startDate.AddYears(noOfYears);

                if (cutoffDate == endDate)
                {
                    return noOfYears.InWords(TimeUnit.Year);
                }
                else
                {
                    if (endDate < cutoffDate)
                    {
                        noOfYears--;
                        noOfMonths = endDate.Month + 12 - startDate.Month;
                    }
                    else
                    {
                        noOfMonths = endDate.Month - startDate.Month;
                    }

                    cutoffDate = startDate.AddYears(noOfYears).AddMonths(noOfMonths);

                    if (cutoffDate == endDate)
                    {
                        list.Add(noOfYears.InWords(TimeUnit.Year));
                        list.Add(noOfMonths.InWords(TimeUnit.Month));

                        return string.Join(", ", list.Where(str => !string.IsNullOrEmpty(str)));
                    }

                    if (endDate < cutoffDate)
                    {
                        noOfMonths--;
                    }

                    noOfDays = (endDate - startDate.AddYears(noOfYears).AddMonths(noOfMonths)).Days;
                    noOfWeeks = noOfDays / 7;
                    leftoverDays = noOfDays % 7;

                    list.Add(noOfYears.InWords(TimeUnit.Year));
                    list.Add(noOfMonths.InWords(TimeUnit.Month));
                    list.Add(noOfWeeks.InWords(TimeUnit.Week));
                    list.Add(leftoverDays.InWords(TimeUnit.Day));

                    return string.Join(", ", list.Where(str => !string.IsNullOrEmpty(str)));
                }
            }
        }
    }
}
