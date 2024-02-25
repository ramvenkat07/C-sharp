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
            var myJsonString = File.ReadAllText(@"C:\Users\ramve\Git\C-sharp\json\sample2.json");
            var myJObject = JObject.Parse(myJsonString);
            Console.WriteLine((string)myJObject.SelectToken("Level2.Title"));
            Console.WriteLine((string)myJObject.SelectToken("Level2.Child1"));
            Console.ReadLine();
            Console.WriteLine(myJObject.SelectToken(""));
            
        }
    }
}
