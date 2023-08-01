using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameRentalShop{
    class Program
    {
        static void Main(string[] args)
        {

            // Example of Game Object: Games Mario = new Games("Mario", "Platformer", "Digital", 19.99, true, "Switch", "Nintendo", "Nintendo");
            // TODO: Write the Method to print out avaliable movies
            // TODO: Give user the option to check games or movies.


            //Welcome User to the rental shop.

            Console.WriteLine( "Welcome to Kirby's Game and Movie Rental Shop!" + "\n");

            //Get input from file and create list of Games objects that will be used to store the contents of the file. 

            List <Games> gamesList = new List <Games> ();
            string gamePath = @"C:\Users\thatr\Documents\C#\Text Files\RentalShop\Games.txt";

            Console.WriteLine("These are the games we have in stock: ");


            using (StreamReader sr = new StreamReader(gamePath))
            {
                //Use the streamreader to read the contents of the file and split the contents into the gameSplit array.
                string line;

                while  ((line = sr.ReadLine()) != null)
                {
                    string[] gameSplit = line.Split(',');

                    //Creating objects
                    Games n = new Games(gameSplit[0], gameSplit[1], gameSplit[2], Convert.ToDouble(gameSplit[3]), bool.Parse(gameSplit[4]), gameSplit[5],
                        gameSplit[6], gameSplit[7]);
                    gamesList.Add (n);

                }
                

            }

            //Print out contents of the Games List .

           foreach (Games l in gamesList)
            {
                l.printGames(l);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //This is were I print out the movies in stock. 

            
            Console.WriteLine(" ");
            Console.WriteLine("These are the Movies we have in stock: ");
            

            string moviePath = @"C:\Users\thatr\Documents\C#\Text Files\RentalShop\Movies.txt";
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