using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Authoring
{
    internal class JsonReader
    {
        public int numberOfAssets;
        internal List<string> assetNameList = new List<string>();
        public void GetData()
        { 
            string myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\source\repos\Authoring\Authoring\Main json.json");
            var myJObject = JObject.Parse(myJsonString);
            var scenario = myJObject.SelectToken("Scenario");
            numberOfAssets = ((JObject)scenario).Count;

            for (int i = 1; i <= numberOfAssets; i++)
            {

                assetNameList.Add((string)myJObject.SelectToken("Scenario.Asset" + i + "" + ".Name"));
            }
        }
    }
}
