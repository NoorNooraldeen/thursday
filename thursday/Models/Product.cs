using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thursday.Models
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public bool InStock { get; set; }

        public bool Stock { get; set; }



        static List<Product> productsList = new List<Product>();
        public void AddProduct (string name , double price, int quantity, bool stock, int counntIn, int countOut )
        {
            productsList.Add(new Product { Name = name, Price = price, Quantity = quantity, Stock = stock });

        }

        //public static bool CheckStock(int quantity)
        //{
           // if (quantity <= 0)
            //    return false;
           // else
             //   return true;
       // }
        
      //  public  string InStock()
        //{
           // if (IsInStock == 0)
            
       // }



        public void DisplayProducts()
        {
            Console.WriteLine(" -----all products -----");
            foreach (Product iteam in productsList) {
                int countIn = 0;
                int countOut = 0;

                if( iteam.Stock == true )
                {
                    countIn++;
                    Console.WriteLine("Name " + iteam.Name + "      " + " Price " + iteam.Price + "kd    " + " Quantity" + iteam.Quantity + "  total  "
                    +(iteam.Price, iteam.Quantity) + "in stock " + countIn);
                }

                else
                {
                    countOut++;
                    Console.WriteLine("Name " + iteam.Name + "      " + " Price " + iteam.Price + "kd    " + " Quantity" + iteam.Quantity + " total  "
                    +(iteam.Price, iteam.Quantity) + "out of stock " + countOut);
                }
            }
        }

        //1
        public string GetInfo(string name)
        {

            return $"Product Name: {name}";
        }

        public string GetPrice(string name, double price)
        {
            return $"Product: {name}, Price: {price}";
        }

        public string GetDisplay(string name, double price, int quantity)
        {
            double total = price * quantity;
            return $"Product: {name}, Price: {price}, Quantity: {quantity}, Total: {total} KD" ;
        }


        public int Calc (int price, int quantity)
        {
            return price * quantity;
        }

       

        public string GetProduct()
        { 
            int countIn = 0;
        int countOut = 0;

        
            foreach( Product iteam in productsList)
            {

                if (iteam.InStock == true)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
                    Console.WriteLine("Name is :" + iteam.Name + " the price is :" + iteam.Price + " the quantity is :" + iteam.Quantity + " total : " + Calc((int)iteam.Price, iteam.Quantity) + "out of stock" + countOut);
            }
            return "in stock" + countIn + "out of stock" + countOut;
        }

    }
}

