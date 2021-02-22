using System;

class HotelCost
{
    static void Main()
    {
      Console.WriteLine("In what season are you booking a stay?");
      string season = Console.ReadLine();
      Console.WriteLine("On the weekend or weeknight?");
      string day = Console.ReadLine();
      bool summer = season == "summer";
      bool weekend = day == "weekend";
      if (summer && weekend) 
      {
        Console.WriteLine("Your stay is probably going to be pretty expensive. It is both - peak travel season and the weekend!");
        else
        {
            Console.WriteLine("Your stay might be expensive but it could be worse.");
        }
      }
    }
}


// class FirstLetterChecker
// {
//     static void Main() 
//     {
//       Console.WriteLine("What is your name?");
//       string userName = Console.ReadLine();
//       if (userName.StartsWith("Z"))
//       {
//           Console.WriteLine("Your name starts with Z");
//       }
//       else
//       {
//           Console.WriteLine("Your name doesn't start with a Z!");
//       }
//     }
// }

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