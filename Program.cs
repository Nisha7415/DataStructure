using System;

namespace linearSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  size of array:- ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in array :- ");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to search :- ");
            int item=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    Console.WriteLine("item is present at " + i + " index position.");
                }
            }
        }
    }
}
