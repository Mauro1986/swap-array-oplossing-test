using System;

namespace MauroGay_SwapArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Array 1 position {i} before swap: {array1[i]}");
            }
            Console.WriteLine();

            for (int j = 0; j < array2.Length; j++)
            {
                Console.WriteLine($"Array 2 position {j} before swap: {array2[j]}");
            }

            Console.WriteLine();
            Console.WriteLine();

            int temp;
            for (int i = 0; i < 6; i++)
            {
                temp = array1[i];
                array1[i] = array2[i];
                array2[i] = temp;
            }

            Console.WriteLine("array 1");
            foreach (var item in array1)
            {
                Console.WriteLine($"Array 1 after: {item}");
            }
            Console.WriteLine();
            Console.WriteLine("array 2");
            foreach (var item in array2)
            {
                Console.WriteLine($"Array 2 after: {item}");
            }
        }
    }
}
