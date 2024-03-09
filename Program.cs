using System;
using System.Collections.Generic;

namespace dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> Dict=new Dictionary<String, String>();
            Dict.Add("cart", "g");
            Dict.Add("Dog", "h");
            Dict.Add("tree,","a");
            Dict.Add("allow", "n");
            

            
            //Dict["tree"] = 9;
            //if (Dict.ContainsKey("Dog"))
            //{ 
            //    Dict["Dog"] = 20;
            //}
            //if (Dict.ContainsValue(9))
            //{
            //    //Console.WriteLine("Item Found.");
            //}
            //Console.WriteLine("Words All Items : ");
            //foreach(KeyValuePair<String, Int16> kvp in Dict)
            //{ 
            //    Console.WriteLine( "Key: {0},Value: {1}",kvp.Key,kvp.Value); 
            //}
            //Dict.Remove("tree");
            //Console.WriteLine("After deleting tree : ");
            //foreach (KeyValuePair<String, Int16> kvp in Dict)
            //{
            //    Console.WriteLine("Key: {0},Value: {1}", kvp.Key, kvp.Value);
            //}
            //Dict.Clear();
        }
    }
}
