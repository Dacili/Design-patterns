using System;
using System.Collections.Generic;

namespace Singleton
{
    class DBContext
    {
        private static string connectionString;
        private static  DBContext dbInstance;

        private DBContext(string connString)
        {
            connectionString = connString;
            Console.WriteLine("DB connection established.");
        }

        public static DBContext getInstanceOfDBContext()
        {
            if (dbInstance == null)
            {
                return dbInstance = new DBContext("bla94949");
            }
            return dbInstance; 
        }

        public static List<string> executeQuery(string command)
        {
            // execute some query
            return new List<string>();
        }

        public static void close()
        {
            Console.WriteLine("DB connection closed.");
        }
    }
}
