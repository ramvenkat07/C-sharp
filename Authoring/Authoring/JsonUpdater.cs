using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Authoring
{
   
    internal class JsonUpdater
    {
        JsonReader reader = new JsonReader();
        internal void UpdateData(List<bool> isDefect)
        {
             
            string myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\Documents\Studio1010\vr-inspection\VR inspection\Assets\Inspection Framework\Resources\Main_json.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);
            reader.GetData();
            for (int i =0; i<isDefect.Count; i++)
            {
                jsonObj[reader.assetNameList[i]]["Defect"] = isDefect[i];
            }
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);

            File.WriteAllText(@"C:\Users\rvuddanti\Documents\Studio1010\vr-inspection\VR inspection\Assets\Inspection Framework\Resources\Main_json.json", output);
            Console.WriteLine("JSON data has been modified and saved.");
        }
           
        
    }
}
