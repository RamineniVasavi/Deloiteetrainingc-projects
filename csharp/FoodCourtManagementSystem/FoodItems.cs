using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagementSystem
{
    public class FoodItems
    {
        public int FoodId;
        public string Name;
        public string Description;
        public string FoodType;
        public string Foodcategory;
        public int price;
    
    public void CreateFood()
    {
        //Step 1 How to create file?
        FileStream fileStreamObj = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\food.txt", FileMode.Create, FileAccess.Write);
        //step 2 How to write file?
        StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            Console.WriteLine("Do you want to add Food item");
            string a=Console.ReadLine();
            while (a == "yes")
            {
                Console.WriteLine("Enter Food Id");
                FoodId = Convert.ToInt32(Console.ReadLine());
                streamWriter.WriteLine("Food Id : " + FoodId);
                Console.WriteLine("Enter Food Name");
                streamWriter.WriteLine("Food Name : " + Console.ReadLine());
                Console.WriteLine("Enter Food Type");
                streamWriter.WriteLine("Food Type : " + Console.ReadLine());
                Console.WriteLine("Enter Food Description");
                streamWriter.WriteLine("Food Description : " + Console.ReadLine());
                Console.WriteLine("Enter Food Category");
                streamWriter.WriteLine("Food Category : " + Console.ReadLine());
                Console.WriteLine("Enter Food Price");
                price = Convert.ToInt32(Console.ReadLine());
                streamWriter.WriteLine("Food Price : " + price);
                Console.WriteLine("Do you want to add Food item");
               a = Console.ReadLine();
            }

            streamWriter.Close();//close writting operation
        fileStreamObj.Close();//close file operation
        Console.WriteLine("File operation completed");
    }
        public void ListallFooditems()
        {
            FileStream fileStream = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\food.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            Console.WriteLine("Food Id\t Name  Type\tDescription\tCategory\tPrice");
            
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] myStrs = line.Split(':');
                if (myStrs[0] != "Food Price ")
                    Console.Write(myStrs[1] + "\t");
                else
                    Console.WriteLine(myStrs[1]);
            }
        }
        public void DetailsofFood()
        {
            Dictionary<int, FoodItems> dictFoodItems = new Dictionary<int, FoodItems>();
            FoodItems foodItems = new FoodItems();
            foodItems.FoodId = 2;
            foodItems.Name = "abc";
            foodItems.Description = "Test";
            dictFoodItems.Add(1, foodItems);
            FileStream fileStream = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\food.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            Console.WriteLine("Enter id of food item ");
            int id=Convert.ToInt32(Console.ReadLine());
            int flag = 0,i=0;
            Console.WriteLine("Food Id\t Name  Type\tDescription\tCategory\tPrice");
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] myStrs = line.Split(':');
                
                if(myStrs[0] == "Food Id " && Convert.ToInt32(myStrs[1])==id)
                {
                    flag = 1;
                }
                if(flag==1) {
                    Console.Write(myStrs[1] + "\t");
                    i++;
                }
                if(i==6)
                {
                    break;
                }

            }


        }
        public void EditExistingdetails()
        {
            FileStream fileStream = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\food.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            Console.WriteLine("Do you want to edit Food item");
            string a = Console.ReadLine();
            while (a == "yes")
            {
                Console.WriteLine("Enter id of food item ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Attribute name of food item ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Attribute value of food item ");
                string value = Console.ReadLine();
                int flag = 0;
                while (streamReaderObj.Peek() > 0)
                {
                    string line = streamReaderObj.ReadLine();
                    string[] myStrs = line.Split(':');

                    if (myStrs[0] == "Food Id " && Convert.ToInt32(myStrs[1]) == id)
                    {
                        flag = 1;
                    }
                    if (flag == 1 && name == myStrs[0])
                    {
                        myStrs[1]=value;
                        break;

                    }

                }
                Console.WriteLine("Do you want to edit Food item");
                a = Console.ReadLine();

            }
            streamWriter.Close();//close writting operation
            fileStream.Close();
        }

}
}
