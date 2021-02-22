using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("At what age would you like to retire? ");

            int ageLeft = Age(age);
            Retired(ageLeft);
            Console.WriteLine("You have " + ageLeft + " years left until you can retire.");
            Year(ageLeft);
            Console.ReadLine();


        }

        static int Age(int age)
        {

            int retireAge = Convert.ToInt32(Console.ReadLine());
            int ageLeft = retireAge - age;
            return ageLeft;
        }

        static public void Year(int ageLeft)
        {
            DateTime thisyear = DateTime.Today;

            int year = thisyear.Year;
            int yearOfRetirement = year + ageLeft;
            Console.WriteLine("It's " + year + ", so you can retire in " + yearOfRetirement + ".");

        }

        static public void Retired(int ageLeft)
        {
            if (ageLeft <= 0)
            {
                Console.WriteLine("you can already retire");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
