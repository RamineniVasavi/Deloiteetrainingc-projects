using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialzation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SerilizationDemo demo = new SerilizationDemo();
            //demo.Xmlserialization();
            //demo.XmlDeserialize();
            //demo.Jsonserialization();
            /* GenericDemo demo = new GenericDemo();
             demo.showsalaryreport(400.20);
             demo.Showagereport(21);
             demo.ShowGenederReport("Anu");
            */
            // SERIALIZATIONTASK sERIALIZATIONTASK = new SERIALIZATIONTASK();
            //sERIALIZATIONTASK.Xmlserialization();
            // sERIALIZATIONTASK.XmlDeserialize();
            deserialization deserialization = new deserialization();
            deserialization.Jsonserialization();
            Console.ReadLine();

        }
    }
}
