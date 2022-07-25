﻿using System;
namespace DemoLibrary;

public abstract class DataAccess
{
    public virtual string LoadConnectionString(string name)
    {
        Console.WriteLine("Load Connection String");
        return "testConnectionString";
    }

    public abstract void LoadData(string sql);

    public abstract void SaveData(string sql);
}

