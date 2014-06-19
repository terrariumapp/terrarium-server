using Terrarium.Server.Models;

namespace Terrarium.Server.Repositories
{
    public interface IUsageRepository
    {
        UserUsageSummary GetUserUsage(string alias, UsagePeriod period);
    }
}