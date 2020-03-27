//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creating and Adding elements in a dictionary
            Console.WriteLine("This is Product Inventory");
            Dictionary<int,string> ProductList=new Dictionary<int,string>();
            ProductList.Add(101,"Handwash");
            ProductList.Add(102,"Sanetizer");
            ProductList.Add(103,"Papersoap");
            ProductList.Add(104,"Facemask");
            ProductList.Add(105,"Dettol");
            ProductList.Add(106,"Tissuepaper");
            foreach(KeyValuePair<int,string> item in ProductList)
            {
                Console.WriteLine("Key : {0}, Value : {1}",item.Key,item.Value);
            }
            
            //Count Operation on a dictionary
            Console.WriteLine("The Total Number Of Inventory Products are : {0}",ProductList.Count);
        }
    }
}