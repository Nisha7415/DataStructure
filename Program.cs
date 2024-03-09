using System;
using System.Collections;
using System.Collections.Generic;


namespace DS_Hashmap
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, int> hashMap = new Dictionary<string, int>();
            hashMap.Add("nisha", 1);
            hashMap.Add("mamata",2);
            hashMap.Add("pooja",3);
            Console.WriteLine("Elements in hashmap are :- ");
            foreach(var i in  hashMap)
            {
                Console.WriteLine(i);
            }
            hashMap.Remove("nisha");
            Console.WriteLine("After removing the element:- ");
            foreach (var i in hashMap)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count of hashmap:- "+hashMap.Count);
        }
    }
}
