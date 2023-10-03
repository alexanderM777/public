using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsTest
{
   public class overloadmethods
    {
        public static void DisplayArray(int[] inputArrays)
        {
            foreach (var item in inputArrays)
            {
                Console.WriteLine($"{item}");
            }
        }
        public static void DisplayArray(double[] inputArrays)
        {
            foreach (var item in inputArrays)
            {
                Console.WriteLine($"{item}");
            }
        }
        public static void DisplayArray(char[] inputArrays)
        {
            foreach (var item in inputArrays)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
