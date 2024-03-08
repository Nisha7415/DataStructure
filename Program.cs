using System;

namespace binarySearch
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
            int item = Convert.ToInt32(Console.ReadLine());
            int lower = 0;
            int higher=array.Length-1;
            int mid=(lower/higher)/2;
            while (lower <= higher)
            {
                if (array[mid]==item)
                {
                    Console.WriteLine("Element is at "+ mid + " index position.");
                    break;
                }
                else if (array[mid]<item) 
                {
                    lower = mid+1;
                }
                else
                {
                    higher = mid - 1;
                }
                mid= (lower+higher)/2;
            }
            if(lower>higher)
            {
                Console.WriteLine("Element not found.");
            }
        }
    }
}
