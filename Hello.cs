using System;

class FirstLetterChecker
{
    static void Main() 
    {
      Console.WriteLine("What is your name?");
      string userName = Console.ReadLine();
      if (userName.StartsWith("Z"))
      {
          Console.WriteLine("Your name starts with Z");
      }
      else
      {
          Console.WriteLine("Your name doesn't start with a Z!");
      }
    }
}

// class Program
// {
//   static void Main()  
//   {
//     Console.WriteLine("Give me a number");
//     string inputNumber = Console.ReadLine();
//     int yourNumber = int.Parse(inputNumber);
//     int yourDouble = yourNumber * 3;
//     string outNumber = yourDouble.ToString();
//     Console.WriteLine($"I doubled it for you: {yourDouble}");
//   }
// }
    
// class RatedR
// {
//     static void Main() 
//     {
//     Console.WriteLine("How old are you?");
//     string sUserAge = Console.ReadLine();
//     int iUserAge = int.Parse(sUserAge);

//     if (iUserAge >= 17)
//     {
//         Console.WriteLine("You can see the movie! ");
//     }
//     else
//     {
//         Console.WriteLine("I am sorry, you are too young to see the movie.");
//     }
//     }
// }