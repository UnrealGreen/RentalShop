using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameRentalShop
{
    internal class Games : Stock
    {
        public string GameConsole { get;  set; }
        public  string Publisher { get; private set; }
        public  string Developer { get; private set; }

        public Games(string name, string genre, string media, double price, bool isInStock, string gameConsole, string publisher, string developer)
            :base(name, genre, media, price, isInStock)
        {
            GameConsole = gameConsole;
            Publisher = publisher;
            Developer = developer;
          
        }
        public Games()
        {

        }

        public void printGames (Games n)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Name: " + n.Name);
            Console.WriteLine("Genre: " + n.Genre);
            Console.WriteLine("Media: " + n.Media);
            Console.WriteLine("Price: " + n.Price);
            Console.WriteLine("IsInStock: " + n.IsInStock);
            Console.WriteLine("Console: " + n.GameConsole);
            Console.WriteLine("Publisher: " + n.Publisher);
            Console.WriteLine("Developer: " + n.Developer);
        }













    }
}
