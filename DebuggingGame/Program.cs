// Purpose: Main program file for the DebuggingGame project.
using DebuggingGame;

Console.WriteLine("The Debugging Game");

Random randGen = new Random();
int bugsKilled = 0;

for (int i = 0; i < 5; i++)
{
    Bug bug = new Fly();  // just to make things happy
    int bugSelect = randGen.Next(1, 4);
    switch(bugSelect)
    {
        case 1:
            bug = new Cockroach();
            break;
        case 2:
            bug = new Fly();
            break;
        case 3:
            bug = new Wasp();
            break;
    }

    Console.WriteLine("A " + bug.Name + " is " + bug.Move() + " toward you!");
    Console.WriteLine("How will you kill it? Spray, swat, or drown it?");
    string exterminator = Console.ReadLine() ?? string.Empty;
    if (bug.Kill(exterminator))
    {
        Console.WriteLine("You killed the " + bug.Name + "!");
        bugsKilled++;
    }
    else
    {
        Console.WriteLine("The " + bug.Name + " got away!");
    }
}
Console.WriteLine("You killed " + bugsKilled + " bugs!");