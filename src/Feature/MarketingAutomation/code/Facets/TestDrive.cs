using System;
using Sitecore.XConnect;

namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Facets
{
    [Serializable]
    [FacetKey(DefaultFacetKey)]
    public class TestDrive : Facet
    {
        public const string DefaultFacetKey = "TestDrive";
        public DateTime TestDriveDate { get; set; }
    }
}