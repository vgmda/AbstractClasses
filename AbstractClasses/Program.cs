﻿using DemoLibrary;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        List<IDataAccess> databases = new List<IDataAccess>()
        {
            new SqlDataAccess(),
            new SqliteDataAccess()
        };

        foreach (var db in databases)
        {
            db.LoadConnectionString("demo");
            db.LoadData("select * from table");
            db.SaveData("insert into table");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
