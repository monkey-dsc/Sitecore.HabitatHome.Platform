using System;
using Sitecore.Analytics.Model.Framework;

namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Facets
{
    public interface ITestDrive : IFacet
    {
        DateTime TestDriveDate { get; set; }
    }
}