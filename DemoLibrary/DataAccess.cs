using System;
namespace DemoLibrary;

// The abstract class DataAccess with virtual and abstract methods

public abstract class DataAccess
{

    // Pre-implmeneted virtual method 
    public virtual string LoadConnectionString(string name)
    {
        Console.WriteLine("Load Connection String");
        return "testConnectionString";
    }
    // Abstract method which NEEDS to be implemented
    public abstract void LoadData(string sql);
    // Abstract method which NEEDS to be implemented
    public abstract void SaveData(string sql);
}

