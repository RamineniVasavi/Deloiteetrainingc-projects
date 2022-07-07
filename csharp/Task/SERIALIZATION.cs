using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task
{
    public class SERIALIZATION
    {
        public int id = 1;
        public string name = "vasavi";
        public string subject = ".net";
    }
    public class serializationdemo {
        public void Jsonserialization()
        {

        }
        public void Xmlserialization()
        {
            SERIALIZATION bs = new SERIALIZATION();
            XmlSerializer xs = new XmlSerializer(typeof(SERIALIZATION));
            TextWriter txt = new StreamWriter(@"C:\Users\RVASAVI\Downloads\csharp\serialization.xml");
            xs.Serialize(txt, bs);
            txt.Close();



        }
    }

    }
}
