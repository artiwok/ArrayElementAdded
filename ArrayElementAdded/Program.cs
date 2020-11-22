using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementAdded
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayElementAdded();
        }

        static void ArrayElementAdded()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Addition of an element to array

            int[] arrTwo = new int[num + 1];

            Console.Write("Enter additional array element's value: ");

            int element = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arrTwo[i] = arr[i];
            }

            for (int i = 0; i < arrTwo.Length; i++)
            {
                arrTwo[arrTwo.Length - 1] = element;

                Console.WriteLine($"{arrTwo[i]} ");
            }

            Console.WriteLine();
        }
    }
}
