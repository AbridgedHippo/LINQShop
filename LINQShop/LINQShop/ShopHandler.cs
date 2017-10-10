using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQShop
{
    class ShopHandler 
    {
        private ItemInventory inventory;

        //constructor
        public ShopHandler()
        {
            inventory = new ItemInventory();
        }
        
        //Add methods to: 
        public static void PriceSort()
        {
            var inventory = new ItemInventory().GetAllItems();

            var HoldItem =
                from i in inventory
                orderby i.Price descending
                select i;

            foreach (Item i in HoldItem)
            {
                Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
            }
        }

        public static void NameSort()
        {
            var inventory = new ItemInventory().GetAllItems();

            var HoldItem =
                from i in inventory
                orderby i.Name
                select i;

            foreach (Item i in HoldItem)
            {
                Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
            }
        }

        public static void PNameSort()
        {
            var inventory = new ItemInventory().GetAllItems();

            var HoldItem =
                from i in inventory
                orderby i.Name
                orderby i.Price
                select i;

            foreach (Item i in HoldItem)
            {
                Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
            }
        }

        public static void CatPriceSort()
        {
            var inventory = new ItemInventory().GetAllItems();

            var HoldItem =
                from i in inventory
                //group by i.Cat
                orderby i.Price
                orderby i.Cat
 
                select i;
           
            foreach (Item i in HoldItem)
            {
                Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
            }
        }
        //return items sorted by name/price and name/price grouped by category      done\price
        //Also to search based on name, price or both at the same time.
        //Use LINQ to query/filter/order/group the items.



    }
}
