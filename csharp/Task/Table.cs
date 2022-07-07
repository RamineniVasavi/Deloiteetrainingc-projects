using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task
{
    internal class Table
    {
        public void Create()
        {
            FileStream fileStream = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            Console.WriteLine("Id\tsource \t\tDestination\tDate\tTime\t\tStatus\tNetwork ");

            while(streamReaderObj.Peek()>0)
            {
                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs.Length==2)
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                    else
                    {
                        for(int i = 1; i < myStrs.Length; i++) {
                            if (i != myStrs.Length - 1)
                            {
                                Console.Write(myStrs[i] + ":");
                            }
                            else {
                                Console.Write(myStrs[i].Remove(2) + "\t");
                            }
                        }
                          
                        
                    }

                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
            fileStream.Close();

        }
    }
}
