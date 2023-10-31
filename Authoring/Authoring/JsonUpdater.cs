using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authoring
{
    internal class JsonUpdater
    {
        internal void UpdateData(List<bool> isDefect)
        {
            string myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\Documents\Unity VR projects\Teleport\Assets\Resources\ScenatioBuilder.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);

            for (int i =0; i<isDefect.Count; i++)
            {
                jsonObj["Scenario"]["Asset" +( i + 1)]["Defect"] = isDefect[i];
            }
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);

            File.WriteAllText(@"C:\Users\rvuddanti\Documents\Unity VR projects\Teleport\Assets\Resources\ScenatioBuilder.json", output);

            Console.WriteLine("JSON data has been modified and saved.");
        }
           
        
    }
}
