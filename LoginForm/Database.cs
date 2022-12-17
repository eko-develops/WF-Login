using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace LoginForm
{
    class Database
    {
        static void CreateConnection()
        {
            try
            {
                SqliteConnection connection = new SqliteConnection("DataSource=database.db");
            }
            catch(SqliteException e)
            {
                Console.WriteLine("SqliteExecption");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Uncaught exception");
                Console.WriteLine(e.Message);
                Console.WriteLine(e);

            }
        }
    }
}
