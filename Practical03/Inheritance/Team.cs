using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical03.Inheritance
{
    // class team that extends Sponsor class
    public class Team: Sponsor
    {
        // defining private variable teamName
        private string teamName;

        // printInfo() method to print owner name and team name;
        public void printInfo()
        {
            Console.WriteLine($"{owner} {teamName}");
        }

        static void Main(string[] args)
        {
            // creating the instance of Team class with teamName
            Team team1 = new Team();
            team1.teamName = "Rainbow";
            
            // calling printInfo() method to print concated string of owner and team name
            team1.printInfo();
        }
    }
}
