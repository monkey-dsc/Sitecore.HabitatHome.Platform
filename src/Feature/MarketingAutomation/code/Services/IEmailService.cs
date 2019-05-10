namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Services
{
    public interface IEmailService
    {
        void SendMail(string to, string from, string subject);
    }
}