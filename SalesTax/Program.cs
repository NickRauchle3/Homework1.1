//Nicholas Rauchle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Program
    {
        const double TaxRate = 8.5;
        static void Main(string[] args)
        {
            //Stating all required constants
            string itemName;
            int myIntegar;
            double price;
            Console.WriteLine("What is the product name of the item you are purchasing?");
            itemName = Console.ReadLine();
            Console.WriteLine("How many " + itemName + " do you want to purchase?");
            myIntegar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the price of " + itemName + "?");
            price = Convert.ToDouble(Console.ReadLine());

            //Code for writing the subtotal, sales tax, and the sales total
            double Subtotal = myIntegar * price;
            double SalesTax = Subtotal * TaxRate;
            double SalesTotal = Subtotal + SalesTax;

            Console.WriteLine("Your subtotal is " + Subtotal);
            Subtotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your sales tax is " + SalesTax);
            SalesTax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your Sales Total is " + SalesTotal);
            SalesTotal = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
            //End of the code
        }
    }
}
