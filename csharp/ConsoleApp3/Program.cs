using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int a, b;
            int c;
            Console.WriteLine("enter a ");
           a = Convert.ToInt32(Console.ReadLine());
           b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
            }
            //Console.Write(a);
            Console.Write(c);
            // comment lines
           */
           
           Event  eventobj = new Event();
            string outp=eventobj.CreateEvent();
            eventobj.SelectEvent();
            

        }
    }
}
