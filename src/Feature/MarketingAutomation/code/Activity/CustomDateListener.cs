using Sitecore.Framework.Conditions;
using Sitecore.HabitatHome.Feature.MarketingAutomation.Services;
using Sitecore.XConnect.Collection.Model;
using Sitecore.Xdb.MarketingAutomation.Core.Activity;
using Sitecore.Xdb.MarketingAutomation.Core.Processing.Plan;

namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Activity
{
    public class CustomDateListener : IActivity
    {
        // Parameters
        public string NoReplyAddress { get; set; }

        public IJobService JobService { get; set; }

        public IEmailService EmailService { get; set; }

        public IActivityServices Services { get; set; }

        // Custom service

        public CustomDateListener(IJobService jobService, IEmailService emailService)
        {
            EmailService = emailService;
            JobService = jobService;
        }

        public ActivityResult Invoke(IContactProcessingContext context)
        {
            Condition.Requires(context.Contact).IsNotNull();

            if (context.Contact.Emails() != null && !context.Contact.ConsentInformation().DoNotMarket)
            {
                var preferredMail = context.Contact.Emails().PreferredEmail.SmtpAddress;

                var subject = "Join us at Symposium!";

                // Change e-mail subject depending on job title
                if (context.Contact.Personal() != null)
                {
                    if (JobService.IsJobInCategory(context.Contact.Personal().JobTitle, JobService.DeveloperCategory))
                    {
                        subject = "Geek out with us at Symposium!";
                    }
                    else if (JobService.IsJobInCategory(context.Contact.Personal().JobTitle, JobService.ExecutiveCategory))
                    {
                        subject = "Magnify your marketing with Sitecore Experience Cloud";
                    }
                }

                EmailService.SendMail(preferredMail, NoReplyAddress, subject);

                // Move to "true" path
                return new SuccessMove("true");
            }

            // Move to "false" path
            return new SuccessMove("false");
        }
    }
}