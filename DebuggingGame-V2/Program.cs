// Purpose: Main program file for the DebuggingGame project.
using DebuggingGame;

int BugAttack(BugFactory factory, int numBugs)
{
    // TODO: Take the I/O out of this method and put it in the Main.
    int deadBugs = 0;
    List<Bug> bugs = new List<Bug>();
    for (int i = 0; i < 5; i++)  // Number of bug attacks
    {
        for (int j = 0; j < numBugs; j++)
        {
            bugs.Add(factory.GetRandomBug());
        }

        foreach (Bug bug in bugs)
        {
            Console.WriteLine("A " + bug.Name + " is " + bug.Move() + " toward you!");
        }

        Console.WriteLine("How will you kill " + (numBugs > 1 ? "them" : "it") + "? (spray, smash, swat, or drown)");
        string exterminator = Console.ReadLine() ?? string.Empty;
        foreach (Bug bug in bugs)
        {
            if (bug.Kill(exterminator))
            {
                Console.WriteLine("You killed the " + bug.Name + "!");
                deadBugs++;
            }
            else
            {
                Console.WriteLine("The " + bug.Name + " got away!");
            }
        }
    }
    return deadBugs;
}

// Main program
Console.WriteLine("The Debugging Game");
int bugsKilled = 0;

BugFactory bugFactory = new BugFactory();

// Level 1
Console.WriteLine("Level 1: Kill one bug at a time");
bugsKilled = BugAttack(bugFactory, 1);
Console.WriteLine("You killed " + bugsKilled + " bugs!");

// Level 2
Console.WriteLine("Level 2: Kill two bugs at a time");
bugsKilled = BugAttack(bugFactory, 2);
Console.WriteLine("You killed " + bugsKilled + " bugs!");
