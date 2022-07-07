using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Event
    {
        public int EventId;
        public string CreateEvent()
        {
            Console.WriteLine("event created");
            return "19";
        }
        public void SelectEvent()
        {
            Console.WriteLine("event selected");
        }

    }
}
