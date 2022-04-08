using System;

namespace ConsoleApp3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempInt;
            int[] array = { 19, 61, 3, 2, 5, 6, 10, 8, 24, 75, 200, 3, 21, 8, 245 };

            Console.Write("начальный массив: ");

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for( int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j< array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tempInt = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempInt;
                    }
                }
                
            }

            Console.Write("\nотсортированный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }            
            Console.ReadKey();
        }
    }
}
