
# MyDictionary
# C#6.0  .NET FRAMEWORK 4.6

The project illustrate how You can create Your own Dictionary.

----

### Purpose
In way, if You want to create Your Own dictionary with some functionality thes example will be useful.

----

### MyDictionary class implementation
```c#
public class MyDict<T1, T2> : IEnumerable
      where T2 : class
{
    //Fields
    private List<T1> List1 = new List<T1>();
    private List<T2> List2 = new List<T2>();

    //Ctors
    public MyDict()
    {


    }

    public MyDict(T1 value) 
    {

    }

    public MyDict(MyDict<T1, T2> my)
    {
      List1 = my.List1;
      List2 = my.List2;
    }

    public MyDict(T1 value1, T2 value2)
    {
      List1.Add(value1);
      List2.Add(value2);
    }

    //Properties

    public int Count
    {
      get
      {
        return List1.Count;
      }
    }

    //Methods
    public void Add(T1 value1, T2 value2)
    {
      List1.Add(value1);
      List2.Add(value2);
    }

    public void cler()
    {
      List1.Clear();
      List2.Clear();
    }

    public bool ContainsKey(T1 value)
    {
      for (int i = 0; i < List1.Count; i++)
      {
        if (List1.Contains(value))
          return true;
      }
      return false;

    }

    public bool ContainsValue(T2 value)
    {
      foreach (T2 t in List2)
        if (t == value)
        {
          Console.WriteLine(t);
          return true;
        }

      return false;

    }

    public void ShowDict()
    {

      for (int i = 0; i < List1.Count; i++)
      {
        Console.WriteLine($"The {i + 1} pair is: {List1[i]}-{List2[i]}");
      }

    }

    public IEnumerator GetEnumerator()
    {
      return List1.GetEnumerator();
    }   
    }
}

```

### Description of MyDictionary class
MyDict class is the generic class and implements IEnumerable interface.
The class has 4 constructors of any object initialization,  two Fields of List, one property which return the count of values in Dictionary and several methods:

  - void Add(T1 value1, T2 value2)
  - void clear()
  - bool ContainsKey(T1 value)
  - bool ContainsValue(T2 value)
  - void ShowDict()
  - IEnumerator GetEnumerator()
  
 
 We can add any functionality for this class.
 
 ### Program class implementation 
 ```c#
 // Creating two Dictionaries with constructors
      MyDict<string, string> dict1 = new MyDict<string, string>();
      MyDict<string, string> dict2 = new MyDict<string, string>("FirstName1", "Lastname1");

      // Adding some values
      dict2.Add("FirstName2", "Lastname2");
      dict2.Add("FirstName3", "Lastname3");

      // Showing the content of dictionary
      dict2.ShowDict();

      // Printing the count of dictionary
      Console.WriteLine(dict2.Count);

      // Creating another dictionary by copying in constructor 
      MyDict<string, string> dict3 = new MyDict<string, string>(dict2);
      dict3.ShowDict();
      Console.WriteLine();

      // Checking availability оф values
      Console.WriteLine(dict2.ContainsKey("FirstName1"));

      // Implementing foreach loop for MyDictionary class
      foreach(string str in dict2)
        Console.WriteLine(str);
 ```
Here are Illustrated the functionality of MyDictionary class, where were created the objects, were invoked the class methods: add(), showDict and etc.

### Result

```c#

```
