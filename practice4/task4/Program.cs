using System;
using System.Globalization; 
using System.Collections; 
using System.Collections.Specialized;



namespace task4
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ListDictionary list = new ListDictionary( new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
      list["Estados Unidos"] = "United States of America";
      list["Canada"] = "Canada";
      list["Espana"] = "Spain";
      
      Console.WriteLine(list["espana"]);
      Console.WriteLine(list["CANADA"]);
      Console.Read();
      
    }
  }
}