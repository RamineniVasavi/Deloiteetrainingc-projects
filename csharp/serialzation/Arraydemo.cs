using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialzation
{
    internal class Arraydemo
    {
        public void gettickets()
        {
            // jagged array 
            string[][] counter = new string[3][];
            counter[0] = new string[4];
            counter[1] = new string[3];
            counter[2] = new string[2];
            counter[0][0] = "P00";
            counter[0][1] = "P01";
            counter[0][2] = "P02";
            counter[0][3] = "P03";

            counter[1][0] = "P10";
            counter[1][1] = "P11";
            counter[1][2] = "P12";

            counter[2][0] = "P20";
            counter[2][1] = "P21";
            



        }
    }
}
