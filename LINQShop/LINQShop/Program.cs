using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQShop
{
    class Program
    {
        private static void Menu()
        {
            char c = 'C';
            {
                while (c != 'x')
                {
                    Console.WriteLine
                        (
                        "Press 1 to sort by Price \nPress 2 to sort by Name \nPress 3 to sort by Price then Name \nPress 4 to sort by Price, grouped by Category \nPress 5 to search by Name \nPress 6 to search by Price \nPress 7 to search by Price and Name \nPress 8 to search by Price OR Name\nPress 0 to to quit."
                        );

                    string input = Console.ReadLine();
                    c = input[0];

                    switch (c)
                    {
                        case '1':
                            ShopHandler.PriceSort();
                            Console.WriteLine();
                            break;
                        case '2':
                            ShopHandler.NameSort();
                            Console.WriteLine();
                            break;
                        case '3':
                            ShopHandler.PNameSort();
                            Console.WriteLine();
                            break;
                        case '4':
                            ShopHandler.CatPriceSort();
                            Console.WriteLine();
                            break;
                        case '0':
                            return;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
           //test
            //Create a menu and make 
            Menu();
            //calls to ShopHandler for search and sort. 
            Console.ReadKey();
        }
    }

    
    /*  
     Enumerations are special sets of named values 
     which all maps to a set of numbers, usually integers. 
     They come in handy when you wish to be able to choose 
     between a set of constant values. 
     Category is here used to define category for Items.
    */
    public enum Category
    {
        Foods,
        Drinks,
        Bread,
        Books,
        Sport
    }
}
//var ps = new ShopHandler();