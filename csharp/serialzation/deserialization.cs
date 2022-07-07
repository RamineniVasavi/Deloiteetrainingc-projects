using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace serialzation
{
    public class Person1
    {
        public int age { get; set; }
        public string Name { get; set; }
        public string city { get; set; }


    }
    internal class deserialization
    {
        public void Jsonserialization()
        {
            var Person1 = new Person1()
            {

                age = Convert.ToInt32(Console.ReadLine()),
                Name = Console.ReadLine(),
                city = Console.ReadLine()
            };
           
            // to serialaize from object to json
            string jsonstring = JsonSerializer.Serialize(Person1);
            // to deserialaize from json to objdf
            var obj = JsonSerializer.Deserialize<Person1>(jsonstring);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.city);
        }
    }
}
