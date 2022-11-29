using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\source\repos\ramvenkat07\C-sharp\json\sample2.json");
            var myJObject = JObject.Parse(myJsonString);
            Console.WriteLine((string)myJObject.SelectToken("Level1.Title"));
            Console.ReadLine();
            Console.WriteLine(myJObject.SelectToken(""));
        }
    }
}
