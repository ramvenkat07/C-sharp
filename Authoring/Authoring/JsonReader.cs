using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Resources;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
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
            string myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\source\repos\C-sharp\Authoring\Authoring\Main json.json");
            var jsonObject = JObject.Parse(myJsonString);
            List<string> topLevelKeys = GetTopLevelKeys(jsonObject);

            foreach (string key in topLevelKeys)
            {
                assetNameList.Add(key);
            }
        }

        static List<string> GetTopLevelKeys(JObject jsonObject)
        {
            List<string> keys = new List<string>();

            foreach (JProperty property in jsonObject.Properties())
            {
                if (property.Name == "Completed")
                {
                    break;
                }
                  
                keys.Add(property.Name);
            }

            return keys;
        }
    }
}
