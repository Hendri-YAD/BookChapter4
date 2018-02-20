using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter4
{
    class Exercise4_16
    {
        public static void Main()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Please enter your month of birth: ");
            int monOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your day of birth: ");
            int dayOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your year of birth: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            HealthProfile me = new HealthProfile(firstName, lastName, gender, monOfBirth, dayOfBirth, yearOfBirth, height, weight);

            Console.WriteLine("My age is {0}", me.GetAge());
            Console.WriteLine("My BMI is {0}", me.GetBMI(me.Weight, me.Height));
            Console.WriteLine("My max heart rate is {0}", me.GetMaxHeartRate);
            Console.WriteLine("My target heart range is {0}-{1}", me.GetMinTargetHeartRate, me.GetMaxTargetHeartRate);


        }

        class HealthProfile
        {
            //attributes 
            string firstName, lastName, gender;
            int monBirth, dayBirth, yearBirth;
            double height, weight;

            //constructor
            public HealthProfile(string firstName, string lastName, string gender, int monBirth, int dayBirth, int yearBirth, double height, double weight)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.monBirth = monBirth;
                this.dayBirth = dayBirth;
                this.yearBirth = yearBirth;
                this.height = height;
                this.weight = weight;
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

            public string Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public int MonBirth
            {
                get { return monBirth; }
                set { monBirth = value; }
            }

            public int DayBirth
            {
                get { return dayBirth; }
                set { dayBirth = value; }
            }

            public int YearBirth
            {
                get { return yearBirth; }
                set { yearBirth = value; }
            }

            public double Height
            {
                get { return height; }
                set { height = value; }
            }

            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
            //methods
            public int GetAge()
            {
                int age = DateTime.Now.Year - YearBirth;

                if (MonBirth > DateTime.Now.Month)
                    return age - 1;
                else if (MonBirth == DateTime.Now.Month && DayBirth > DateTime.Now.Day)
                    return age - 1;

                return age;
            }

            public int GetMaxHeartRate
            {
                get
                {
                    return 220 - GetAge();
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

            public double GetBMI(double weight, double height)
            {
                return Weight / (Height * Height);
            }



        }


    }
}
