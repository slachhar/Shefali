using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {5,1,14,12,9 };

            for(int iteration=1; iteration< intArray.Length; iteration++)
            {
                for(int number=0;number<intArray.Length-1;number++)
                {
                    if (intArray[number] > intArray[number + 1])
                    {
                        int temp = intArray[number];
                        intArray[number] = intArray[number + 1];
                        intArray[number + 1] = temp;
                    }
                }
                Console.WriteLine(string.Join(",",intArray));
            }
            Console.ReadLine();
        }
    }
}
