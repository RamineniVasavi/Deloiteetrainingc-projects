using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//File handling
namespace CsharpApplication
{
    internal class Movie
    {
        public void CreateMovie()
        {
            //Step 1 How to create file?
            FileStream fileStreamObj = new FileStream(@"C:\Training\movie.txt", FileMode.Create, FileAccess.Write);
            //step 2 How to write file?
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            streamWriter.WriteLine("MovieId:123");
            streamWriter.WriteLine("MovieName:RRR");
            streamWriter.WriteLine("MovieDesc:Action");
            streamWriter.WriteLine("MovieLanguage:Telugu");
            streamWriter.Close();//close writting operation
            fileStreamObj.Close();//close file operation
            Console.WriteLine("File operation completed");
        }

        public void SelectMovies()
        {
            FileStream fileStream = new FileStream(@"C:\Training\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());

            //how to read all the date from file?
            //Console.WriteLine(streamReaderObj.ReadToEnd());


            //How to declare array?
            //Fixed array and Dynamic array?
            string[] myValues = new string[5];
            myValues[0] = "A";
            myValues[1] = "A";
            myValues[2] = "A";
            myValues[3] = "A";
            myValues[4] = "A";
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] myStrs = line.Split(':');
                Console.WriteLine(myStrs[1]);
            }
            fileStream.Close();
        }
    }
}
//File handling


