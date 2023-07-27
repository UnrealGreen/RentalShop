using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRentalShop
{
    internal class Movies : Stock
    {
        private string Director { get; set; }

        public Movies (string name, string genre, string media, double price, bool isInStock, string director) 
            : base(name, genre, media, price, isInStock)
        {
            Director = name;
           

        }

    }
}
