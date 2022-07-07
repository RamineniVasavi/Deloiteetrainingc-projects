using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace serialzation
{
    public class Person
    {
        
        public int age;

        public string name;
        public string city;

        public Person PersonData()
        {
            Person person = new Person();
            person.age=Convert.ToInt32(Console.ReadLine());
            person.name=Console.ReadLine();
            person.city=Console.ReadLine();
            return person;
        }


    }
    public class SERIALIZATIONTASK
    {
        public void Xmlserialization()
        {
            Person ps = new Person();
            ps = ps.PersonData();

            XmlSerializer xs = new XmlSerializer(typeof(Person));
            TextWriter txt = new StreamWriter(@"C:\Users\RVASAVI\Downloads\csharp\serialization1task.xml");
            xs.Serialize(txt, ps);
            txt.Close();



        }
        
        public void XmlDeserialize()
        {
            Person ps = new Person();
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            StreamReader txt = new StreamReader(@"C:\Users\RVASAVI\Downloads\csharp\serialization1task.xml");
            ps = (Person)xs.Deserialize(txt);
            Console.WriteLine(ps.name);
            Console.WriteLine(ps.age);
            Console.WriteLine(ps.city);



        }



    }
}
