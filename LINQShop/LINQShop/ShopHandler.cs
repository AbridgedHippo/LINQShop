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
                group i by new
                {
                    i.Cat
                    //price = i.Price,
                    //name = i.Name
                };

            foreach (var obj in HoldItem)
            {

                Console.WriteLine("----------Category: {0}---------", obj.Key.Cat);
                foreach (var l in obj)
                {
                    Console.WriteLine("Price: {1}\t name: {0}", l.Name, l.Price);
                }
                Console.WriteLine();
            }

            //var HoldItem =
            //    from i in inventory
            //    orderby i.Price,
            //            i.Cat
            //    select i;

            //foreach (Item i in HoldItem)
            //{
            //    Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
            //}
        }
        //return items sorted by price, name/price and name/price grouped by category      done\

        public static void NameSearch()
        {
            Console.WriteLine("input c to search for items containing your input term\ninput e to make an exact search for your intput");

            char c = 'C';
            string input = Console.ReadLine();
            c = input[0];

            var inventory = new ItemInventory().GetAllItems();
            string search = Console.ReadLine();

            if (input == "c")
            {
                var HoldItem =
                    from i in inventory
                    where i.Name.Contains(search) //Equals(search)
                    select i;

                foreach (Item i in HoldItem)
                {
                    Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
                }
            }

            else if (input == "e")
            {
                var HoldItem =
                    from i in inventory
                    where i.Name.Equals(search)
                    select i;

                foreach (Item i in HoldItem)
                {
                    Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
                }
            }
            else
            {
                return;
            }
        }

        public static void PriceSearch()
        {
            Console.WriteLine("input > for items of cost or above or < for items of cost or below");
            var inventory = new ItemInventory().GetAllItems();
            string input = Console.ReadLine();
            double search = double.Parse(Console.ReadLine());

            if (input == ">")
            {
                var HoldItem =
                    from i in inventory
                    where i.Price >= search
                    orderby i.Price ascending
                    select i;

                foreach (Item i in HoldItem)
                {
                    Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
                }
            }
            else if (input == "<")
            {
                var HoldItem =
                    from i in inventory
                    where i.Price <= search
                    orderby i.Price descending
                    select i;

                foreach (Item i in HoldItem)
                {
                    Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
                }
            }
            else
            {
                return;
            }
        }

        //Also to search based on name, price or both at the same time.
        public static void PnNSearch()
        {
            Console.WriteLine("input Price of product");
            var inventory = new ItemInventory().GetAllItems();
            // string input = Console.ReadLine();
            double searchP = double.Parse(Console.ReadLine());
            Console.WriteLine("input Name of product");
            string searchN = Console.ReadLine();

            var HoldItem =
            from i in inventory
            where i.Name.Contains(searchN)
            where i.Price <= searchP
            orderby i.Price ascending
            select i;

            foreach (Item i in HoldItem)
            {
                Console.WriteLine("Price: {1}\t Category: {2}\t Name: {0}", i.Name, i.Price, i.Cat);
            }


        }

        //foreach (Category c in Enum.GetValues(typesof(Category)))
        //    Console.Write(char.ToString() + " ");


        public static void CatSelectSearch()
        {

            foreach (Category c in Enum.GetValues(typesof(Category)))
                Console.Write(char.ToString() + " ");



        }

        public static void CatStuffs()
        {
            //var inventory = new ItemInventory().GetAllItems();

            //string cat = Enum.ToObject(inventory);
            //Console.WriteLine(cat);
        }
        //Use LINQ to query/filter/order/group the items.

        //public static void CatSelectSearch()
        //{
        //    var inventory = new ItemInventory().GetAllItems();

        //    var HoldItem =
        //        from i in inventory

        //}




    }

}
