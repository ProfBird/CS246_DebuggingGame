using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingGame
{
    public interface Bug
    {
        public string Name { get; }
        public string Move();

        public bool Kill(string exterminator);

    }

    public class Cockroach : Bug
    {
        public string Name { get; } = "cockroach";
        public string Move() {
            return "Crawling";
        } 

        public bool Kill(string exterminator) {
            return exterminator.ToLower() == "spray";
        }
    }

    public class Fly : Bug
    {
        public string Name { get; } = "fly";
        public string Move()
        {
            return "flying";
        }

        public bool Kill(string exterminator)
        {
            return exterminator.ToLower() == "swat";
        }
    }
}
