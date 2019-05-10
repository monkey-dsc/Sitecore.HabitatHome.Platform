using System.Collections.Generic;

namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Services
{
    public class JobService : IJobService
    {
        public string DeveloperCategory => "developer";

        public string MarketerCategory => "marketer";

        public string ExecutiveCategory => "executive";

        private List<string> DeveloperJobTitles { get; set; }
        private List<string> MarketerJobTitles { get; set; }
        private List<string> ExecutiveJobTitles { get; set; }

        public JobService()
        {
            DeveloperJobTitles = new List<string>
            {
                "developer",
                "software developer",
                "software engineer"
            };

            MarketerJobTitles = new List<string>
            {
                "marketer",
                "digital strategist",
                "marketing manager"
            };

            ExecutiveJobTitles = new List<string>
            {
                "ceo",
                "coo",
                "cdo"
            };
        }

        public bool IsJobInCategory(string job, string category)
        {
            if (category == DeveloperCategory)
            {
                return DeveloperJobTitles.Contains(job.ToLowerInvariant());
            }

            if (category == MarketerCategory)
            {
                return MarketerJobTitles.Contains(job.ToLowerInvariant());
            }

            if (category == ExecutiveCategory)
            {
                return ExecutiveJobTitles.Contains(job.ToLowerInvariant());
            }

            return false;
        }
    }
}