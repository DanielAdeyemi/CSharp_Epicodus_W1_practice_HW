using System;
class Program
{
  static void Main()  
  {
    Console.WriteLine("Give me a number");
    string inputNumber = Console.ReadLine();
    int yourNumber = int.Parse(inputNumber);
    int yourDouble = yourNumber * 2;
    string outNumber = yourDouble.ToString();
    Console.WriteLine($"I doubled it for you: {yourDouble}");
  }
}
    