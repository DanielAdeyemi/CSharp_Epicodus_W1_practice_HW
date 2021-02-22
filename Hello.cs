using System;
using System.Collections.Generic;

class PhineBook
{
    public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
    static void Main() // interacting with a user through a console
    {
      Console.WriteLine("Main Menu");
      Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no.");
      string answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        AddContact();
      }
      else
      {
          Console.WriteLine("Would you like to look up number in your phone book? ['Y for yes', 'Enter' for no]" );
          string finishedAnswer = Console.ReadLine();
          if (finishedAnswer == "Y" || finishedAnswer == "y")
          {
             LookUpContact();              
          }
          else
          {
              Main();
          }
      }
    }
    static void AddContact()
    {
      Console.WriteLine("NEW CONTACT");
      Console.WriteLine("Enter a new contact name");
      string name = Console.ReadLine();
      Console.WriteLine("Enter a new contact phone");
      string number = Console.ReadLine();
      if (phoneNumbers.ContainsKey(name))
      {
        Console.WriteLine($"That person already in your list. Their phone is {phoneNumbers[name]}");
      }
      else
      {
          phoneNumbers.Add(name, number);
      }
    }
    static void LookUpContact()
    {

    }
}

// class HotelCost
// {
//     static void Main()
//     {
//       Console.WriteLine("In what season are you booking a stay?");
//       string season = Console.ReadLine();
//       Console.WriteLine("On the weekend or weeknight?");
//       string day = Console.ReadLine();
//       bool summer = season == "summer";
//       bool weekend = day == "weekend";
//       if (summer && weekend) 
//       {
//         Console.WriteLine("Your stay is probably going to be pretty expensive. It is both - peak travel season and the weekend!");
//       }
//         else if (summer || weekend)
//         {
//             Console.WriteLine("Your stay might be more expensive than normal.");
//         }
//         else if (!(summer || weekend))
//         {
//             Console.WriteLine("This is the cheapest possible option");
//         }
//         else
//         {
//             Console.WriteLine("Your stay might be expensive but it could be worse.");
//         }
//     }
// }


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