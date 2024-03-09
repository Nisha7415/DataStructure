using System;
using System.Collections.Generic;
using System.Linq;

namespace hashSets
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> set = new HashSet<String>();
            set.Add("C");
            set.Add("java");
            set.Add("python");
            set.Add("c#");
            Console.WriteLine("The elements in hashset1 are : ");
            //foreach(String i in set)
            //{
            //    Console.WriteLine(i);
            //}
            //set.Remove("java");
            //Console.WriteLine("After removing element : ");
            //foreach (String i in set)
            //{
            //    Console.WriteLine(i);
            //}
            //set.Clear();
            //Console.WriteLine("After clear : ");
            //foreach (String i in set)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(" Number of elements present in set");
            //Console.WriteLine(set.Count);
            HashSet<String> list = new HashSet<String>();
            list.Add("C");
            list.Add(".net");
            list.Add("mysql");
            list.Add("python");
            //set.UnionWith(list);
            set.IntersectWith(list);
            foreach (String i in set)
            {
                Console.WriteLine(i);
            }

        }
    }
}
