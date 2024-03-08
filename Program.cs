using System;

namespace insertionSort
{
  public class Program
    {
        static void Main(string[] args)
        {
            int temp, j;
            Console.WriteLine("Enter the  size of array:- ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in array :- ");
            int[] array= new int[n];
            for(int i=0; i<n; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for( int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                j = i;
                while(j > 0  && array[j-1]>temp)
                {
                    array[j] = array[j-1];
                    j--;
                }
            }
            for (int i = 1;i< array.Length; i++)
            {
                Console.WriteLine(array[i]);



            }
        }
    }
}
