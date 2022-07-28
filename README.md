# AbstractClasses

> An abstract class is a special type of class that cannot be instantiated. An abstract class is designed to be inherited by subclasses that either implement or override its methods. In other words, abstract classes are either partially implemented or not implemented at all.

Data **abstraction** is the process of hiding specific details and showing only essential information to the user. To achieve **abstraction**, the keyword `abstract` is used.

*   **Abstract class:** is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
*   **Abstract method:** It can only be used in an abstract class and does not have a body. The body is provided by the derived class (inherited from).

Below is an example of `DataAccess` an abstract class with three methods:

`LoadConnectionString` - A virtual method provides an implementation option, and the derived class can override.

`LoadData` and `SaveData` - Are abstract methods and do not provide an implementation option meaning the class that inherits it will **have** to override it. 

```c#
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
```

Below is a snippet of code where `SqliteDataAccess` class inherits from `DataAccess`, therefore it `overrides` the methods from the abstract class. 

```c#
public class SqliteDataAccess : DataAccess
{
   public override string LoadConnectionString(string name)
   {
       string output = base.LoadConnectionString(name);
       return output += " (from SQLite)";
   }
   public override void LoadData(string sql)
   {
       Console.WriteLine("Loading SQLite Data");
   }
   public override void SaveData(string sql)
   {
       Console.WriteLine("Saving data to SQLite");
   }
}
```

## Abstract Method
* Abstract Method resides in abstract class and it has no body.
* Abstract Method must be overridden in non-abstract child class.
## Virtual Method
* Virtual Method can reside in abstract and non-abstract class.
* It is not necessary to override virtual method in derived but it can be.
* Virtual method must have body can be overridden by "override keyword"
