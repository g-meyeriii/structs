using System;
using System.Globalization;

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


            ////Enums can be used to share a set of constants, ex place in the namespace and can be shared across all the classes in that name space;
            //enum Day { Mo,Tu,We,Th,Fr,Sa,Su}
            
            //enum Month { Jan=1,Feb,Mar,Apr,May,Jun,Jul=12,Aug,Sep,Oct,Nov,Dec};

        static void Main(string[] args)
        {
            //Day fr = Day.Fr;
            //Day su = Day.Su;

            //Day a = Day.Fr;



            //Console.WriteLine(fr== a);

            //Console.WriteLine(Day.Mo);
            //Console.WriteLine((int)Day.Mo);

            //Console.WriteLine((int)Month.Feb);
            //Console.WriteLine((int)Month.Aug);
            //Game game1;

            //game1.Display();

            //game1.name = "Dragamon Go";
            //game1.developer = "Joe";
            //game1.rating = 3.5;
            //game1.releaseDate = "1/7/2019";


            //game1.Display();

            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            
            Console.WriteLine("Floor: " + Math.Floor(15.3));
           

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2 ));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3,5));
            Console.WriteLine("Pi is: {0}", Math.PI);
            Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("Always positive is {0}", Math.Abs(-25) );
            Console.WriteLine("cos of 1 is {0}", Math.Cos(1));

            Console.ReadLine();
        }
    }
}
