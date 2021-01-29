using Facade;
using Factory;
using Iterator;
using Singleton;
using System;

namespace designPatternsMedi
{
    class Program
    {
        static void Main(string[] args)
        {
            //// SINGLETON PATTERN
            //Logging logger = Logging.getInstance();
            //Logging.getInstance();
            //Logging.logError("Medi haker err test");
            //Console.ReadKey();

            //// FACTORY
            //while (true)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Enter:");
            //    Console.WriteLine("D - for DELL laptop");
            //    Console.WriteLine("H - for HP laptop");
            //    Console.WriteLine("X - for exit");
            //    var decision = Console.ReadKey();
            //    Console.WriteLine();
            //    if (decision.Key == ConsoleKey.D)
            //    {
            //        var dell = new CreateLaptopDELL();
            //        dell.doSomething();
            //    }
            //    else if (decision.Key == ConsoleKey.H)
            //    {
            //        var hp = new CreateLaptopHP();
            //        hp.doSomething();
            //    }
            //    else if (decision.Key == ConsoleKey.X)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You entered wrong char.");
            //    }
            //}

            //// ABSTRACT FACTORY
            // var createHP = new AbstractFactory.CreatorHP();
            // createHP.doSomething();
            // Console.WriteLine();
            // var createDELL = new AbstractFactory.CreatorDELL();
            // createDELL.doSomething();
            // Console.ReadKey();

            // FACADE
            //var myWeatherApp = new Forecast();
            //object result = myWeatherApp.GetForecast("Sarajevo");
            //Console.WriteLine("Full result:");
            //Console.WriteLine(result);
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("Mini info - my facade:");
            //var myWeatherApp2 = new ForecastMinInfo();
            //Console.WriteLine(myWeatherApp2.GetForecastMiniInfo("Sarajevo")); //Tokyo , Mecca
            //Console.ReadKey();

            // ITERATOR
            var btt = new BinaryTryTree();
            ITreeIterator iterator = btt.createIterator();
            iterator.moveDownTop();
            iterator.moveTopDown();
            Console.ReadKey();

        }
    }
}
