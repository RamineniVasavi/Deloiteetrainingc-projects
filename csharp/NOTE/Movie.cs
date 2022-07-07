using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NOTE
{
    internal class Movie
    {
       
        public void CreateMovie()
        {
         // create a file
         FileStream fileStream = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\movie.txt",FileMode.Create,FileAccess.Write);
          // to write file
          StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("movieid:123");
            streamWriter.WriteLine("movie name:abcd");
            streamWriter.WriteLine("movie lang: telugu");

            string name=Console.ReadLine();
            int id = Convert.ToInt32(Console.ReadLine());
            string lang = Console.ReadLine();
            streamWriter.WriteLine("moviename:"+name);
            streamWriter.WriteLine("movieid:"+id);
            
            streamWriter.WriteLine("movie lang: "+lang);


            streamWriter.Close();
            fileStream.Close(); 
            Console.WriteLine("file operation completed");


        }
        public void SelectMovies()
        {
            FileStream fileStream = new FileStream(@"C:\Users\RVASAVI\Downloads\csharp\movie.txt",FileMode.Open,FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);   
            /*Console.WriteLine(streamReader.ReadLine());
            Console.WriteLine(streamReader.ReadLine());
            Console.WriteLine(streamReader.ReadLine());
            Console.WriteLine(streamReader.ReadLine());
            */
           while(streamReader.Peek()>0)
            {
               string line=streamReader.ReadLine();
                string[] str1=line.Split(':');
                Console.WriteLine(str1[1]);
            }
           
           //Console.WriteLine(streamReader.ReadToEnd());
           fileStream.Close();
            //streamReader.Close(); no need of closing streamreader class 


        }
    }
}
