using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRentalShop
{
    internal class Stock
    {
        public string Name { get;  set; }
        public string Genre { get; private set; }
        public string Media { get; private set; }
        public double Price { get; private set; }
        public  bool IsInStock { get; private set; }



        public Stock(string name, string genre, string media, double price, bool isInStock)
        {
            Name = name;
            Genre = genre;
            Media = media;
            Price = price;
            IsInStock = isInStock;

            
        }

        public Stock()
        {

        }

        public double StockPrice() //This method will be used to determine the price of a movie considering a few factors
        {
            double result = 0;

            return result;


        }




        
    }
}
