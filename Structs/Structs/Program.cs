using System;

namespace Structs
{
    class Program
    {   //Stucts: No default constructor must define parameters, no inheritence, can't be virtual abstract or protected
        //structs WORK BY VALUES, not by reference which is what classes do.

        //struct Game
        //{
        //    public string name;
        //    public string developer;
        //    public double rating;
        //    public string releaseDate;

        //    public Game(string name, string developer, double rating, string releaseDate)
        //    {
        //        this.name = name;
        //        this.developer = developer;
        //        this.rating = rating;
        //        this.releaseDate = releaseDate;
        //    }

        //    public void Display()
        //    {
        //        Console.WriteLine("Game 1's name is {0}", name);
        //        Console.WriteLine("Game 1's developer is {0}", developer);
        //        Console.WriteLine("Game 1's rating is {0}", rating);
        //        Console.WriteLine("Game 1's release date is {0}", releaseDate);
        //    }
        //}

            enum Day { Mo,Tu,We,Th,Fr,Sa,Su}
            
            enum Month { Jan=1,Feb,Mar,Apr,May,Jun,Jul=12,Aug,Sep,Oct,Nov,Dec};

        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;



            Console.WriteLine(fr== a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);
            //Game game1;

            //game1.Display();

            //game1.name = "Dragamon Go";
            //game1.developer = "Joe";
            //game1.rating = 3.5;
            //game1.releaseDate = "1/7/2019";


            //game1.Display();

            Console.ReadKey();
        }
    }
}
