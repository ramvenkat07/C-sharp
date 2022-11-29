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
            var myJsonString = File.ReadAllText(@"C:\Users\rvuddanti\source\repos\json\sample2.json");
            var myJObject = JObject.Parse(myJsonString);
            Console.WriteLine(myJObject.SelectToken("firstName").Value<string>());
            Console.WriteLine(myJObject.SelectToken(""));
        }
    }
}
