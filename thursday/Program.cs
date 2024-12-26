// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Diagnostics.Tracing;
using thursday.Models;

Product product = new Product();
Product p = new Product();
int Count;
string NAME;
double PRICE;
int QTY;
int countIn = 0;
int countOut = 0;
bool stock=false;
Console.WriteLine("enter how many products you have please !");
Count = Convert.ToInt32(Console.ReadLine());

// this will only accepts one product name !!
//Console.WriteLine("Enter product name:");
//string name = Console.ReadLine();
//Console.WriteLine(product.GetInfo(name));


// acc only product name and price 

//Console.WriteLine("Enter product name:");
// name = Console.ReadLine();
//Console.WriteLine("Enter product price:");
//double price = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(product.GetPrice(name, price));


// ac product name , price quantity 

//Console.WriteLine("Enter product name:");
//name = Console.ReadLine();
//Console.WriteLine("Enter product price:");
//price = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter product quantity:");
//int quantity = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(product.GetDisplay(name, price, quantity));


for (int i = 1; i <= Count; i++)
{
    Console.WriteLine("enter the name of the product ");
    NAME = Console.ReadLine();
    Console.WriteLine(" please enter the price :");
    PRICE = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("enter the quantity of the products ");
    QTY = Convert.ToInt32(Console.ReadLine());

    // for  ( int  x = 1; x<= QTY; x++ )

    Console.Write("enter avaliblity for the iteam");
    stock = Convert.ToBoolean(Console.ReadLine());
    p.AddProduct(NAME, PRICE, QTY, stock, countIn, countOut);





}

    p.DisplayProducts();
    p.GetProduct();
Console.WriteLine(p.GetProduct);