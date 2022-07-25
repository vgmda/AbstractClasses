using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary;

public class SqlDataAccess : DataAccess
{

    public void LoadData(string sql)
    {
        Console.WriteLine("Loading Microsoft SQL Data");
    }

    public void SaveData(string sql)
    {
        Console.WriteLine("Saving data to Microsoft SQL Server");
    }
}
