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
<<<<<<< HEAD
            var myJsonString = File.ReadAllText(@"C:\Users\ramve\Git\C-sharp\json\sample2.json");
            var myJObject = JObject.Parse(myJsonString);
            Console.WriteLine((string)myJObject.SelectToken("Level2.Title"));
            Console.WriteLine((string)myJObject.SelectToken("Level2.Child1"));
=======
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
>>>>>>> 1def10e684757741de50909ef1b0b4886e5a1c7b
            Console.ReadLine();
        }
    }
}
