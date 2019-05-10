namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Services
{
    public interface IJobService
    {
        string DeveloperCategory { get; }
        string MarketerCategory { get; }
        string ExecutiveCategory { get; }

        bool IsJobInCategory(string job, string category);
    }
}