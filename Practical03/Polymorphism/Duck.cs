using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical03.Polymorphism
{
    // Duck class which extends Bird class
    public class Duck: Bird
    {
        // Voice() method of Duck class which prints Duck's voice
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }

        // main method which creates instance of Bird and Duck class and call Voice() method
        static void Main(string[] args)
        {
            // instance of Bird and Duck class
            Bird myBird = new Bird();
            Duck myDuck = new Duck();
            
            // calling method Voice() using both the instances
            myBird.Voice();
            myDuck.Voice();
        }
    }
}
