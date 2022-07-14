using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            FoodItems foodItems = new FoodItems();
            Console.WriteLine("To add Food items enter 1 || to list all items enter 2 ||  for details of all food enter 3|| for editing enter 4 ");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    foodItems.CreateFood();
                    break;
                case 2:
                    foodItems.ListallFooditems();
                    break;
                case 3:
                    foodItems.DetailsofFood();
                    break;
                case 4:
                    foodItems.EditExistingdetails();
                    break;
                

            }

            Console.ReadLine();
        }
    }
}
