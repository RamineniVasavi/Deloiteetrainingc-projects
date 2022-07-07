using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
namespace serialzation
{
    public class Employee
    {
        public int id = 1;
        public string name = "vasavi";
        public string subject = ".net";

    }
    public class WeatherForecast
    {
        public DateTimeOffset date { get; set; }
        public int Temperaturecelsius { get; set; }
        public String summary { get; set; }
    }
    public class SerilizationDemo
    {
        public void Jsonserialization()
        {
            var WeatherForecast = new WeatherForecast
            {
                date = DateTime.Parse("2019-08-01"),
                Temperaturecelsius = 25,
            summary = "Hot"

        };
            // to serialaize from object to json
        string jsonstring = JsonSerializer.Serialize(WeatherForecast);
            // to deserialaize from json to objdf
        var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonstring);
            Console.WriteLine(obj.date);
            Console.WriteLine(obj.Temperaturecelsius);
            Console.WriteLine(obj.summary);

        }
        public void Xmlserialization()
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter txt = new StreamWriter(@"C:\Users\RVASAVI\Downloads\csharp\serialization.xml");
            xs.Serialize(txt, bs);
            txt.Close();



        }
        public void XmlDeserialize()
         {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            StreamReader txt = new StreamReader(@"C:\Users\RVASAVI\Downloads\csharp\serialization.xml");
            bs=(Employee)xs.Deserialize(txt);
            Console.WriteLine(bs.name);
            Console.WriteLine(bs.subject);
            Console.WriteLine(bs.id);



        }
        
    }
}
