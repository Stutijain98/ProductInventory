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
            
            Console.WriteLine("This is Product Inventory Details");
            Dictionary<string,int> ProductDetail=new Dictionary<string,int>();
            ProductDetail.Add("Handwash",150);
            ProductDetail.Add("Sanetizer",100);
            ProductDetail.Add("Papersoap",5);
            ProductDetail.Add("Facemask",40);
            ProductDetail.Add("Dettol",200);
            ProductDetail.Add("Tissuepaper",100);
            //Getting List all products
            foreach(KeyValuePair<string,int> item in ProductDetail)
            {
                Console.WriteLine("Product Name: {0}, Price : {1}",item.Key,item.Value);
            }
           
            
            //Getting List Of All Keys and Values in Dictionary separately
            Dictionary<string,int>.KeyCollection keys = ProductDetail.Keys;    
              foreach (string key in keys)    
                   {    
                     Console.WriteLine("Name: {0}", key);    
                   }
            
            Dictionary<string,int>.ValueCollection values = ProductDetail.Values;    
              foreach (int val in values)    
                   {    
                     Console.WriteLine("Price: {0}", val);    
                   }
        
        
            //Searching for particular key or value
           
            if(ProductDetail.ContainsKey("Dettol"))
               {
                   Console.WriteLine("Product Found");
               }
            
            else
               {
                Console.WriteLine("No such product");
               }
            //value
            
            if(ProductDetail.ContainsValue(100))
               {
                   Console.WriteLine("Product Found");
               }
            
            else
               {
                Console.WriteLine("No such product");
               }
            
            
           
        }       
            
    }
}

