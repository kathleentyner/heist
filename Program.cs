// Plan Your Heist
// A C# Exercise
// The Story
// You are poor. After much, deep consideration, it occurs to you that if you were to get some money, you wouldn't be so poor.

// With this insight you begin to consider where to get money... Banks have money, you think to yourself, maybe I could take some of that. Thus, your dream of a bank heist is born.

// Even though you are amazing at everything you do, you realize you cannot rob a bank alone. You'll need a team. But who should you recruit? Of course, you have a rolodex full of criminal masterminds, but you must be selective. Invite too many and each person's take is too small. Invite too few and your heist will fail. Also, you realize, you'll need to take luck (random chance) into account.

// Maybe you could write a C# program to help you?

// The Exercise
// This program will be written in phases. Along the way you will get some practice with classes, methods, properties, loops, lists, and more...

// Phase One
// The program should...

// Print the message "Plan Your Heist!".
// Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
// Prompt the user to enter a team member's name and save that name.
// Prompt the user to enter a team member's skill level and save that skill level with the name.
// Prompt the user to enter a team member's courage factor and save that courage factor with the name.
// Display the team member's information.
using System;

    class Program
{

 static void Main()
{   AddHeistMember();
   
}

static void AddHeistMember()
{
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Plan Your Heist!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();


{
    HeistTeam heistTeam = new HeistTeam();
  
    Console.WriteLine("Add members to your heist team. Enter a the name of a criminal:");
        string? Name = Console.ReadLine();
        if (Name == "")
        {
                ChooseBank();

        }
    Console.WriteLine();

    Console.WriteLine($"How skilled of a criminal is {Name}? Enter a number between 1 and 10 with 10 being the most skilled:");
        int Skill = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Rate {Name}'s courage factor. Enter a number between 1 and 10 with 10 being the most couragous:");
        int Courage = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    
    HeistMember singleHeistMember = new HeistMember(Name, Skill, Courage);
        heistTeam.AddToTeam(singleHeistMember);


    Console.WriteLine($"Ok, {Name} is a member of your heist team. {Name} has a skill level of {Skill} and a courage factor of {Courage}.");
    Console.WriteLine();
              //   Console.WriteLine($"Your team has {heistTeam.heistTeam.Count} members: {heistTeam} ");     
  
 AddHeistMember();
            
}
static void ChooseBank()
{
Bank bank = new Bank();
Console.WriteLine($"How hard should the robbery be? Select a difficulty level between 1 and 20:");
    int Difficulty = Convert.ToInt32(Console.ReadLine());
                
                bank.Difficulty = Difficulty;


}}}




// Sum the skill levels of the team. Save that number.
// Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.




// Phase Four
// The program should be updated to...

// Create a random number between -10 and 10 for the heist's luck value.
// Add this number to the bank's difficulty level.
// Before displaying the success or failure message, display a report that shows.
// The team's combined skill level
// The bank's difficulty level
// Phase Five
// The program should be updated to...

// Run the scenario multiple times.
// After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
// Phase Six
// The program should be updated to...

// At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// At the end of the program, display a report showing th

