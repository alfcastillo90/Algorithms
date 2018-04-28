using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion sort!");
            int[] array = { 9, 6, 12, 4, 43 };
            Console.WriteLine("Before 9, 6, 12, 4, 43 ");
            int newValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                newValue = array[i];
                int j = i;
                while(j>0 && array[j - 1] > newValue)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = newValue;
            }
            Console.Write("Array after sort: ");
            foreach (int val in array)
            {
                Console.Write(val + ",");
            }
            Console.ReadLine();
        }
    }
}
