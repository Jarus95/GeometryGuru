using System;
namespace GeometrGuru
{
  class Program
  {
     static void Main()
     {
      bool isRepeat = false;
      do
      {
        Console.WriteLine("1. Find base of triangle");
        Console.WriteLine("2. Area calculator");
        int answer = int.Parse(Console.ReadLine());
        switch(answer)
        {
           case 1:
           {
              Random rand = new Random();

              double randomHeight = rand.Next(1, 50);
              double randomArea = rand.Next(1, 50);
              bool isCorrect = false;
             
              do
              {
                 Console.WriteLine("Formula: (base = 2 * area) / height");
                 Console.WriteLine($"height: {randomHeight}");
                 Console.WriteLine($"area: {randomArea}");
                 Console.Write($"Base: ");
                try
                {
                   double userBase = double.Parse(Console.ReadLine());
                   double CorrectBase =  (2 * randomArea) / randomHeight;
 
                   userBase = Math.Round(userBase,  2);
                   CorrectBase = Math.Round(CorrectBase, 2);
 
                   if(userBase == CorrectBase)
                   {
                      Console.WriteLine("Correct !");
                      isCorrect = true; 
                   }
                   else
                   {
                      Console.WriteLine("Wrong ! try again");
                   }
                }

                catch(Exception ex)
                {
                  Console.WriteLine(ex.Message);
                }
              }

              while(!isCorrect);
              break;
           }

           case 2:
           {
               Console.WriteLine("Enter the base triangle");
               Console.Write("base of a triangle: ");
               string baseTriangle = Console.ReadLine();

               Console.WriteLine("Enter the height triangle");
               Console.Write("height of a triangle: ");
               string heightTriangle = Console.ReadLine();

               Console.WriteLine("Calculating Area...");
               try
               {
                  decimal triangleBase = decimal.Parse(baseTriangle);
                  decimal traiangleHeight = decimal.Parse(heightTriangle);

                  if(traiangleHeight <= 0 || triangleBase <= 0)
                       Console.WriteLine("Invalid input");
                  else 
                  {
                      decimal Surface = (triangleBase * traiangleHeight) / 2;
                      Console.WriteLine("Area: " + Surface);  
                  }                  
               }

               catch(Exception ex)
               {
                  Console.WriteLine(ex.Message);
               }
                    
               break;             
           }

           default: 
           {
              Console.WriteLine("Invalid input");
              break;
           }            
        }
             Console.WriteLine();
             Console.Write("Do you want to Repeat? [y/n]: ");
             string yesOrNo = Console.ReadLine();
             isRepeat = yesOrNo == "y" ? true : false;           
      }

      while(isRepeat);
     }
  }
}
