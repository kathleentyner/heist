

using System;

class Program
{

    static void Main()
    {
        Heist();

    }

    static void Heist()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Plan Your Heist!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Enter the bank difficulty level. Choose between 1 - 100."); 
        int Difficulty = Convert.ToInt32(Console.ReadLine()); 
        AddHeistMember(); //call method the add a Heist member

    }
    static public List<HeistMember> HeistMembers = new List<HeistMember>(); //ability to add more team members to a list

    static void AddHeistMember() //method to create a user 

    {
        string? Name;
        int Skill;
        int Courage;

        Console.WriteLine();
        Console.WriteLine("What is your criminal's name:");
        Name = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"How skilled of a criminal is {Name}? Enter a number between 1 and 10 with 10 being the most skilled:");
        Skill = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (Name == "") ;

        Console.WriteLine($"Rate {Name}'s courage factor. Enter a number between 1 and 10 with 10 being the most couragous:");
        Courage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Ok, {Name} is a member of your heist team. {Name} has a skill level of {Skill} and a courage factor of {Courage}.");
        Console.WriteLine();

        var heistMember = new HeistMember(Name, Skill, Courage); //add each individual member to the list
        HeistMembers.Add(heistMember);

//logic to add another member. could have used a while loop and note if name == ""
        string? answer = Console.ReadLine().ToLower();

        while (answer != "y" && answer != "n")
        Console.WriteLine($"Your team has {HeistMembers.Count} members. Would you like to add another team member? (Y/N):"); //ability to add another team member.
            answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            AddHeistMember();
        }

        if (answer =="n")
        {  Console.WriteLine($"How many trial runs would you like to simulate?:");
            int Trials = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine($"How hard should the robbery be? Select a difficulty level between 1 and 20:");
        
        int Difficulty = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine($"The bank has a dificulty of {Difficulty} and you will similate {Trials} trial runs.");

        for (int i = 1; i <= Trials; i++)// loop through the trials based on the user trial run input          
          
{
                int? skillTotal = HeistMembers.Sum(member => member.Skill); //calculate the total team skill

                
                int Luck = new Random().Next(-10, 10);// Create a random number between -10 and 10 for the heist's luck value.
                int success = 0; 
                int lose = 0;

                if (skillTotal >= Difficulty+Luck)
                {
                    success++;
                    // Console.WriteLine($"Your Heist Team's skill level is {skillTotal}. The Banks difficulty level is {Difficulty + Luck}. you should have enought skillzzzz to rob this bank."); //If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message,
                }
                else
                {
                   lose++;
                    // Console.WriteLine($"Your Heist Team's skill level is {skillTotal}.The Banks difficulty level is {Difficulty + Luck}.Your team needs more skilllllzzzzzzzzzzzzz");


                }
            }

        }
    }
}



// Phase Six
// The program should be updated to...

// At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// At the end of the program, display a report showing the number of successful runs and the number of failed runs.