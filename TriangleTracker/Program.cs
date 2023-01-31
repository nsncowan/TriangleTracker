using System;
using TriangleTracker.Models;

namespace TriangleTracker
{

  public static class Program {
    public static void Main(){
      Console.WriteLine("Please Enter the Length of Side 1");
      string stringSide1 = Console.ReadLine();
      int side1 = int.Parse(stringSide1);

      Console.WriteLine("Please Enter the Length of Side 2");
      string stringSide2 = Console.ReadLine();
      int side2 = int.Parse(stringSide2);

      Console.WriteLine("Please Enter the Length of Side 3");
      string stringSide3 = Console.ReadLine();
      int side3 = int.Parse(stringSide3);

      Triangle shape = new Triangle(side1,side2,side3);
      Console.WriteLine("The shape you have is "+ shape.TriangleType());
    }
  }
}