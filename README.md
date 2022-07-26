# AbstractClasses

> An abstract class is a special type of class that cannot be instantiated. An abstract class is designed to be inherited by subclasses that either implement or override its methods. In other words, abstract classes are either partially implemented or not implemented at all.

Data **abstraction** is the process of hiding specific details and showing only essential information to the user. To achieve **abstraction**, the keyword `abstract` is used.

*   **Abstract class:** is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
*   **Abstract method:** It can only be used in an abstract class and does not have a body. The body is provided by the derived class (inherited from).

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
