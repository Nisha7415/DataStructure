using System;

namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min,temp=0;
            Console.WriteLine("Enter the size of array:- ");
            int n=Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine("Enter the elements in array :- ");
            int[] a=new int[n];
            for(int i=0; i<n; i++)
            {
                min = i;
                for(int j=i+1;j<a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        min = j;
                    }
                }
                temp = a[i];
                a[i]= a[min];
                a[min]= temp;

            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(a[i]);

            }
        }
    }
}
