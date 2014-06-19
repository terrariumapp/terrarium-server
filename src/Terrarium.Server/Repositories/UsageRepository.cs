using System;
using System.Linq;
using Terrarium.Server.DataModels;
using Terrarium.Server.Models;

namespace Terrarium.Server.Repositories
{
    public class UsageRepository : IUsageRepository
    {
        private readonly ITerrariumDbContext _context;

        public UsageRepository(ITerrariumDbContext context)
        {
            _context = context;
        }

        public UserUsageSummary GetUserUsage(string alias, UsagePeriod period)
        {
            var startDate = DateTime.MinValue;
            var endDate = DateTime.MinValue;

            GetPeriodDates(period, ref startDate, ref endDate);

            // TODO get query working with null data
//            var minutes = _context.Usages
//                .Where(x => x.Alias == alias && (x.TickTime >= startDate && x.TickTime <= endDate))
//                .Sum(x => x.UsageMinutes);

            var minutes = 0;

            var summary = new UserUsageSummary();

            summary.Alias = alias;
            summary.Period = period;
            summary.TotalHours = minutes/60;

            var span = endDate - startDate;
            if (span.Days == 0)
            {
                span = new TimeSpan(1, 0, 0, 0);
            }
            summary.AverageHours = (float)summary.TotalHours/span.Days;

            return summary;
        }

        /// <summary>
        /// This is a helper function to give proper dates given the UsagePeriod
        /// </summary>
        /// <param name="period">The period we care about</param>
        /// <param name="startDate">The startDate, to be filled in by this function</param>
        /// <param name="endDate">The endDate, to be filled in by this function</param>
        private static void GetPeriodDates(UsagePeriod period, ref DateTime startDate, ref DateTime endDate)
        {
            switch (period)
            {
                case UsagePeriod.Today:
                    {
                        startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                        endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                        break;
                    }
                case UsagePeriod.Week:
                    {
                        startDate = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek));
                        startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0);
                        endDate = DateTime.Now.AddDays(((int)DayOfWeek.Saturday) - ((int)DateTime.Now.DayOfWeek));
                        endDate = DateTime.Now.AddDays(1);
                        endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);
                        break;
                    }
                case UsagePeriod.Total:
                    {
                        startDate = new DateTime(2005, 5, 24);
                        endDate = DateTime.Now.AddDays(1);
                        break;
                    }
            }
        }
    }
}