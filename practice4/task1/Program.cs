using System;
using System.Collections;

namespace task1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ArrayList myList = new ArrayList(); 
      myList.Add(4);
      myList.Add(3);
      myList.Add(2);
      myList.Add(1);
      foreach (int item in myList) {
        Console.WriteLine("Unsorted: {0}", item);
      }

      myList.Sort();
      foreach (int item in myList) {
        Console.WriteLine("Sorted: {0}", item);
      }

    }
  }
}