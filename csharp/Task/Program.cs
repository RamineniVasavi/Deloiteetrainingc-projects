using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Table table = new Table();
           // table.Create();
           serializationdemo serdemo=new serializationdemo();
            serdemo.Xmlserialization();
            Console.ReadLine();

        }
    }
}
