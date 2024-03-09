using System;
using System.Collections;

namespace hashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable Htable=new Hashtable();
            Htable.Add(1, 23);
            Htable.Add(2, "a");
            Htable.Add(3, 45);
            Htable.Add(4, "c");
            //foreach(object i in Htable.Keys)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach(object j in Htable.Values)
            //{
            //    Console.WriteLine(j);
               
            //}
            foreach (DictionaryEntry dic in Htable)
            {

                Console.WriteLine("keys={0}  values={1}", dic.Key, dic.Value);
               

            }
            Console.WriteLine(Htable.Contains(5));
            Console.WriteLine(Htable.ContainsValue(45));
           

        }
    }
}
