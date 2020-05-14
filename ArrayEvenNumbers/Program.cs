using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any 10 numbers:\n");
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter any numbers : ", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\nOutput: Even numbers are");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    Console.WriteLine("{0} ", nums[i]);
            }
            Console.WriteLine("\n\nEnter any key to Quit!");
            Console.ReadLine();
        }
    }
}
