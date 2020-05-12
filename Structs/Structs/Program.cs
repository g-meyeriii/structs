using System;

namespace Structs
{
    class Program
    {
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public void Display()
            {
                Console.WriteLine("Game 1's name is {0}", name);
                Console.WriteLine("Game 1's developer is {0}", developer);
                Console.WriteLine("Game 1's rating is {0}", rating);
                Console.WriteLine("Game 1's release date is {0}", releaseDate);
            }
        }

        static void Main(string[] args)
        {
            Game game1;

            game1.name = "Dragamon Go";
            game1.developer = "Joe";
            game1.rating = 3.5;
            game1.releaseDate = "1/7/2019";


            game1.Display();

            Console.ReadKey();
        }
    }
}
