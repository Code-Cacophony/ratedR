using System;

class RstedR
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string stringUserAge = Console.ReadLine();
    int intUserAge = int.Parse(stringUserAge);

    if (intUserAge >= 17)
    {
      Console.WriteLine("You can see the movie!");
    }
    else
    {
      Console.WriteLine("I'm sorry, you are too young to see the movie.");
    }
  }
}