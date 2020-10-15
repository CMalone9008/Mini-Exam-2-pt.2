using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

  double side1 = 0;
  double side2 = 0;
  double determineHyp = 0;

  Console.WriteLine("Enter side1:");
  side1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Enter side2:");
  side2 = Convert.ToDouble(Console.ReadLine());
  determineHyp = Math.Sqrt((side1*side1) + (side2*side2));
  Console.WriteLine("Hypotenuse = " + determineHyp);

  }
}