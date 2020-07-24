using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Setting and outputting field values

      var bob = new Person();
      bob.Name = "Bob Smith";
      bob.DateOfBirth = new DateTime(1965, 12, 22);

      WriteLine(
        format: "{0} was born on {1:dddd, d MMMM yyyy}",
        arg0: bob.Name,
        arg1: bob.DateOfBirth);

      var alice = new Person
      {
        Name = "Alice Jones",
        DateOfBirth = new DateTime(1998, 3, 7)
      };

      WriteLine(
        format: "{0} was born on {1:dd MMM yy}",
        arg0: alice.Name,
        arg1: alice.DateOfBirth);

      // Storing a value using an enum type

      bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

      WriteLine(format: 
        "{0}'s favourite wonder is {1}. It's integer is {2}.",
        arg0: bob.Name,
        arg1: bob.FavouriteAncientWonder,
        arg2: (int)bob.FavouriteAncientWonder);

      // Storing multiple values using an enum type

      bob.BucketList = 
        WondersOfTheAncientWorld.HangingGardensOfBabylon
        | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

      // bob.BucketList = (WondersOfTheAncientWorld)18; 

      WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

      // Storing multiple values using collections

      bob.Children.Add(new Person { Name = "Alfred" }); 
      bob.Children.Add(new Person { Name = "Zoe" });

      WriteLine(
        $"{bob.Name} has {bob.Children.Count} children:");

      for (int child = 0; child < bob.Children.Count; child++)
      {
        WriteLine($"  {bob.Children[child].Name}");
      }

    // Now redo loop as a foreach 
     WriteLine(
        "\nRedoing loop as a foreach ...\n");
      foreach (Person child in bob.Children)
      {
        WriteLine($"  {child.Name}");
      }


        }
    }
}
