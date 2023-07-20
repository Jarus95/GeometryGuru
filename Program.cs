using System;
namespace GeometrGuru
{
  class Program
  {
     static void Main()
     {
        Console.WriteLine("Enter the base triangle");
        Console.Write("base of a triangle: ");
        string baseTriangle = Console.ReadLine();

        Console.WriteLine("Enter the height triangle");
        Console.Write("height of a triangle: ");
        string heightTriangle = Console.ReadLine();

        System.Console.WriteLine("Calculating Area...");

        decimal triangleBase = decimal.Parse(baseTriangle);
        decimal traiangleHeight = decimal.Parse(heightTriangle);
        decimal S = (triangleBase * traiangleHeight) / 2;

        System.Console.WriteLine("Area: " + S);
        
     }
  }
}
