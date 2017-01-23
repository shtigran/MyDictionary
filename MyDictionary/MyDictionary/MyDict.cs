using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyDictionary 
{
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

    public void clear()
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
