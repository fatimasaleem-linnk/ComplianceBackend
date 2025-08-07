using Hangfire.Dashboard;

namespace ComplianceAndPeformanceSystem.API.Common
{

    public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            return true;
        }
    }
}
