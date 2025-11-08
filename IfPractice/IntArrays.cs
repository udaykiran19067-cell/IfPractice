using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPractice
{
    public class IntArrays
    {
        public void intArrayMethod()
        {
            // Creating an integer array
            int[] numbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("Integer Array elements:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                if (num == 70)
                {
                    break;
                }
            }
        }
    }
}
