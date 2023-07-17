using System;
namespace GeometrGuru
{
  class Program
  {
     static void Main()
     {
        Console.WriteLine("Enter the base triangle");
        Console.Write("b: ");
        string baseTriangle = Console.ReadLine();

        Console.WriteLine("Enter the height triangle");
        Console.Write("h: ");
        string heightTriangle = Console.ReadLine();

        System.Console.WriteLine("Calculating Area...");

        decimal b = decimal.Parse(baseTriangle);
        decimal h = decimal.Parse(heightTriangle);
        decimal S = (b*h)/2;

        System.Console.WriteLine("Area: " + S);




     }
  }
}
