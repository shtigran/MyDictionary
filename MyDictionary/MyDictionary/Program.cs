using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Showing MyDictionary class:\n ");
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

      // Checking availability of values
      Console.WriteLine(dict2.ContainsKey("FirstName1"));

      // Implementing foreach loop for MyDictionary class
      foreach(string str in dict2)
        Console.WriteLine(str);

      Console.ReadKey();
    }
  }
}