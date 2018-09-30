using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class TestedClass
    {
        public bool TriangleCheck(double firstSidetr, double secondSidetr, double thirdSidetr)
        {
            if ((firstSidetr + secondSidetr > thirdSidetr) && (secondSidetr + thirdSidetr > firstSidetr) && (firstSidetr + thirdSidetr > secondSidetr))            
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
