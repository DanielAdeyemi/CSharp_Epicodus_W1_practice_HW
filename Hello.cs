using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}

public class Program //UI
{
  public static void Main()
  {
    Car volkswagen = new Car();
    volkswagen.MakeModel = "1974 Volkswagen Thing";
    volkswagen.Price = 1100;
    volkswagen.Miles = 368792;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 56000;

    Car ford = new Car();
    ford.MakeModel = "1988 Ford Country Squire";
    ford.Price = 1400;
    ford.Miles = 239001;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 400;
    amc.Miles = 198000;

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
    Console.WriteLine("Enter max price: ");
    string sMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(sMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);
    foreach(Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);        
    }
  }
}





// class Phonebook
// {
//   public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

//   static void Main()
//   {
//     Console.WriteLine("MAIN MENU");
//     Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
//     string answer = Console.ReadLine();
//     if (answer == "Y" || answer == "y")
//     {
//       AddContact();
//     }
//     else
//     {
//       Console.WriteLine("Would you like to lookup a number in your phone book? ['Y' for yes, 'Enter' for no]");
//       string lookUpAnswer = Console.ReadLine();
//       if (lookUpAnswer == "Y" || lookUpAnswer == "y")
//       {
//         LookUpContact();
//       }
//       else
//       {
//         Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
//         string finishedAnswer = Console.ReadLine();
//         if (finishedAnswer == "Y" || finishedAnswer == "y")
//         {
//           Console.WriteLine("Goodbye.");
//         }
//         else
//         {
//           Main();
//         }
//       }
//     }
//   }

//   static void AddContact()
//   {
//     Console.WriteLine("NEW CONTACT");
//     Console.WriteLine("Enter a new contacts name");
//     string name = Console.ReadLine();
//     Console.WriteLine("Enter a new contacts phone number");
//     string number = Console.ReadLine();
//     if (phoneNumbers.ContainsKey(name))
//     {
//       Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
//     }
//     else
//     {
//       phoneNumbers.Add(name, number);
//     }
//     Main();
//   }

//   static void LookUpContact()
//   {
//     Console.WriteLine("CONTACT LOOKUP");
//     Console.WriteLine("Whose number would you like to look up?");
//     string friend = Console.ReadLine();
//     if (phoneNumbers.ContainsKey(friend))
//     {
//       string value = phoneNumbers[friend];
//       Console.WriteLine(friend + "\'s phone number is " + value);
//     }
//     else
//     {
//       Console.WriteLine("That person is not in your phone book.");
//     }
//     Main();
//   }
// }

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