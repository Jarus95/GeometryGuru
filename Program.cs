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

        Console.WriteLine("Calculating Area...");
        decimal triangleBase = decimal.Parse(baseTriangle);
        decimal traiangleHeight = decimal.Parse(heightTriangle);

         if(traiangleHeight <= 0 || triangleBase <= triangleBase)
              Console.WriteLine("Invalid input");
         else 
         {
             decimal Surface = (triangleBase * traiangleHeight) / 2;
             Console.WriteLine("Area: " + Surface);  
         } 
     }
  }
}
