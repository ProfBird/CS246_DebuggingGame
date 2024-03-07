namespace DebuggingGame;

public class BugFactory
{
    const string COCKROACH = "cockroach";
    const string FLY = "fly";
    const string WASP = "wasp";
    const string ANT = "ant";
    
    // Returns a specific bug.
    public Bug GetBug(string bugType)
    {
        Bug bug;
        switch(bugType.ToLower())
        {
            case COCKROACH:
                bug = new Cockroach();
                break;
            case FLY:
                bug = new Fly();
                break;
            case WASP:
                bug = new Wasp();
                break;
            case ANT:
                bug = new Ant();
                break;
            default:
                bug = new Fly();  // The default bug.
                break;
        }
        return bug;
    }
    
    
    // Returns a random bug.
    public Bug GetRandomBug()
    {
        Bug bug;
        Random randGen = new Random();
        int bugSelect = randGen.Next(1, 4);
        switch(bugSelect)
        {
            case 1:
                bug = GetBug(COCKROACH);
                break;
            case 2:
                bug = GetBug(FLY);
                break;
            case 3:
                bug = GetBug(WASP);
                break;
            default:
                bug = GetBug(FLY); // default bug
                break;
        }
        return bug;
    }
}