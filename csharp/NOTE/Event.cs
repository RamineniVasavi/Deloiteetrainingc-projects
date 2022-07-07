using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE
{
    internal class Event
    {
        public int Id;
        public string Name;
        public string Description;
        public string Type; 
        public void CreateEvent()
        {
            Id = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Description = Console.ReadLine();
            Type = Console.ReadLine();

        }
        public void SelectEvent()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);    
            Console.WriteLine(Description);
            Console.WriteLine(Type);

        }

    }
}
