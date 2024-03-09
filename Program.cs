using System;
using System.Collections.Generic;

namespace DS_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);

            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            // Console.WriteLine(list.Count);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            //list.AddRange(list);
            list.Remove(3);
            //list.RemoveAt(0);         
            //list.RemoveRange(3, 2);
            //Console.WriteLine(list.Contains(4));
            //list.Reverse();
            //Console.WriteLine(list.IndexOf(3));
            //Console.WriteLine(list.LastIndexOf(3));
            Console.WriteLine("----------------------");
            //list.Clear();
            Console.WriteLine(list.ToArray());
            
            //list.Insert(1, 10);
            //list.InsertRange(2, list);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
