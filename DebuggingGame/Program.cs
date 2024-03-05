// See https://aka.ms/new-console-template for more information
using DebuggingGame;

Console.WriteLine("Hello, World!");

Random randGen = new Random();

for (int i = 0; i < 10; i++)
{
    Bug bug = new Fly();  // just to make things happy
    int bugSelect = randGen.Next(1, 3);
    switch(bugSelect)
    {
        case 1:
            bug = new Cockroach();
            break;
        case 2:
            bug = new Fly();
            break;
    }

    Console.WriteLine("The " + bug.Name + " is " + bug.Move());

}