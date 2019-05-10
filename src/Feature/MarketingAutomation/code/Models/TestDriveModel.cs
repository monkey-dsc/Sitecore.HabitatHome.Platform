using Sitecore.HabitatHome.Feature.MarketingAutomation.Facets;
using Sitecore.XConnect;
using Sitecore.XConnect.Collection.Model;
using Sitecore.XConnect.Schema;

namespace Sitecore.HabitatHome.Feature.MarketingAutomation.Models
{
    public class TestDriveModel
    {
        public static XdbModel Model { get; } = BuildModel();

        private static XdbModel BuildModel()
        {
            var modelBuilder = new XdbModelBuilder("TestDriveModel", new XdbModelVersion(0, 1));

            modelBuilder.ReferenceModel(CollectionModel.Model);
            modelBuilder.DefineFacet<Contact, TestDrive>(TestDrive.DefaultFacetKey);

            return modelBuilder.BuildModel();
        }
    }
}