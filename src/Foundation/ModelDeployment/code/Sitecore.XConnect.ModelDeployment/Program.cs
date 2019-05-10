using System;
using System.IO;
using Sitecore.HabitatHome.Feature.MarketingAutomation.Models;
using Sitecore.XConnect.Serialization;

namespace Sitecore.XConnect.ModelDeployment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Serialize();
        }

        public static void Serialize()
        {
            var model = XdbModelWriter.Serialize(TestDriveModel.Model);
            File.WriteAllText(TestDriveModel.Model.FullName + ".json", model);
            Console.WriteLine("Completed");
            Console.Read();
        }
    }
}