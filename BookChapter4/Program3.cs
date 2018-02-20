using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter4
{
    class Exercise4_15
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your year of birth: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());            

            int currYear = DateTime.Now.Year;

            HeartRates a = new HeartRates(firstName, lastName, yearOfBirth, currYear);

            Console.WriteLine("Current age is {0}", a.GetAge);
            Console.WriteLine("Max heart rate is {0}", a.GetMaxHeartRate);
            Console.WriteLine("Target heart range is {0}-{1}", a.GetMinTargetHeartRate, a.GetMaxTargetHeartRate);

        }

        class HeartRates
        {
            //attributes
            string firstName, lastName;
            int yearOfBirth, currYear;            

            //constructor
            public HeartRates(string firstName, string lastName, int yearOfBirth, int currYear)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.yearOfBirth = yearOfBirth;
                this.currYear = currYear;
            }


            //properties
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public int YearOfBirth
            {
                get { return yearOfBirth; }
                set { yearOfBirth = value; }
            }

            public int CurrYear
            {
                get { return currYear; }
                set { currYear = value; }
            }

            public int GetAge
            {
                get
                {
                    return CurrYear - YearOfBirth;
                }
            }

            public int GetMaxHeartRate
            {
                get
                {
                    return 220 - GetAge;
                }
            }

            public double GetMinTargetHeartRate
            {
                get
                {
                    return 0.50 * GetMaxHeartRate;
                }
            }

            public double GetMaxTargetHeartRate
            {
                get
                {
                    return 0.85 * GetMaxHeartRate;
                }
            }

        }



    }
    

}
