using System;
using System.Collections;

namespace DS_ArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            Console.WriteLine(mylist.Capacity);
            mylist.Add(10);
            mylist.Add("Nisha");
            mylist.Add(20);
            mylist.Add(30);
            Console.WriteLine(mylist.Capacity);
           foreach(object obj in mylist)
            {
                Console.Write(obj + " ");


            }
           Console.WriteLine();
            mylist.Insert(2,25);
            mylist.Remove("Nisha");
            foreach (object obj in mylist)
            {
                Console.Write(obj + " ");
            }
            


        }
    }
}
