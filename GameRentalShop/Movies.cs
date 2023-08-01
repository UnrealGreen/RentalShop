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
            Director = director;
           

        }

        public Movies()
        {

        }
        //Prints out what Movies we have
        public void printMovies(Movies n)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Name: " + n.Name);
            Console.WriteLine("Genre: " + n.Genre);
            Console.WriteLine("Media: " + n.Media);
            Console.WriteLine("Price: " + n.Price);
            Console.WriteLine("IsInStock: " + n.IsInStock);
            Console.WriteLine("Directed by: " + n.Director);
           
        }

        
        //Prints out what is in stock
        //Might Not Need this
        public void whtsInStock(string path)
        {
            Console.WriteLine(" ");
            Console.WriteLine("These are the Movies we have in stock: ");


            //string moviePath = @"C:\Users\thatr\Documents\C#\Text Files\RentalShop\Movies.txt";
            string moviePath = @path;
            List<Movies> movieList = new List<Movies>();




            using (StreamReader sr = new StreamReader(moviePath))
            {
                //Use the streamreader to read the contents of the file and split the contents into the gameSplit array.
                string line2;

                while ((line2 = sr.ReadLine()) != null)
                {
                    string[] movieSplit = line2.Split(',');

                    //Creating objects
                    Movies n = new Movies(movieSplit[0], movieSplit[1], movieSplit[2], Convert.ToDouble(movieSplit[3]), bool.Parse(movieSplit[4]), movieSplit[5]);
                    ;
                    movieList.Add(n);

                }


            }

            //Print out contents of the Games List .

            foreach (Movies k in movieList)
            {
                k.printMovies(k);
            }

        }

    }
}
