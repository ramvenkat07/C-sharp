using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            string myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\source\repos\C-sharp\json\sample2.json");
            var myJObject = JObject.Parse(myJsonString);
            var scenario = myJObject.SelectToken("Scenario");
           
            int numberOfAssets = ((JObject)scenario).Count;
            for (int i = 1; i <= numberOfAssets; i++) 
            {

                string AssetName = (string)myJObject.SelectToken("Scenario.Asset" + i + "" + ".Name");
                Console.WriteLine("Asset name :"+AssetName);

                if ((bool)myJObject.SelectToken("Scenario.Asset" + i + "" + ".Defect"))
                {
                    Console.WriteLine("Defect : true");
                }
                else
                {
                    Console.WriteLine("Defect : false");
                }
            }
            Console.ReadLine();
        }
    }
}
