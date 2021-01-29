using System;
using System.IO;

namespace Singleton
{
    public class Logging
    {
        private static DBContext dbContextLogging;
        private static Logging instance = new Logging(); // here is instance creation

        static Logging() // static - to initialize static fields
        {
            Console.WriteLine("Static constr: Logger created.");
           
            dbContextLogging = DBContext.getInstanceOfDBContext();
            DBContext.getInstanceOfDBContext();
        }

        public static Logging getInstance()
        {
            return instance; // no need for checking null
        }

        public static void logError(string err)
        {
            string fullPath = "C:\\Users\\Daca\\source\\repos\\designPatternsMedi\\Singleton\\errorsLog.txt";
            using (StreamWriter writer = new StreamWriter(fullPath, append: true))
            {
                writer.WriteLine(err);
                Console.WriteLine(err + " is logged.");
            }
        }
    }
}
