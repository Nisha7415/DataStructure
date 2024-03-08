using System;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array :- ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elemnets in array :- ");
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < array.Length; i++)
            {
                for(int j=0;j<array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp;
                        temp = array[j];
                        array[j]= array[j + 1];
                        array[j+1]= temp;
                    }
                }
            }
            for(int i= 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
