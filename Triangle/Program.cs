using System;
using Triangle;
public class Program
{
  public static void Main()
  {
    Tracker newTracker = new Tracker();
    Console.WriteLine("Enter three numbers to find out if they make a triangle.");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Enter your first number: ");
    string stringNum1 = Console.ReadLine();
    int num1 = int.Parse(stringNum1);
    Console.WriteLine("Enter your second number: ");
    string stringNum2 = Console.ReadLine();
    int num2 = int.Parse(stringNum2);
    Console.WriteLine("Enter your third number: ");
    string stringNum3 = Console.ReadLine();
    int num3 = int.Parse(stringNum3);
    Console.WriteLine("--------------------------");
    Console.WriteLine("Is it a Scalene Triangle? " + newTracker.IsScalene(num1, num2, num3));
    Console.WriteLine("Is it an Equilateral Triangle? " + newTracker.IsEquilateral(num1, num2, num3));
    Console.WriteLine("Is it an Isosceles Triangle? " + newTracker.IsIsosceles(num1, num2, num3));

  }
}
