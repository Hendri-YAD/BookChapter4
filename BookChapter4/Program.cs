using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter4
{
    class Exercise4_13
    {
        static void Main(string[] args)
        {
            Employee a = new Employee("Blood", "Seeker", 1000M);
            Employee b = new Employee("Templar", "Assassin", 10000M);

            a.dispYearSal();
            b.dispYearSal();

            a.MonthlySalary = a.MonthlySalary * 1.1M;
            b.MonthlySalary = b.MonthlySalary * 1.1M;

            a.dispYearSal();
            b.dispYearSal();

        }
    }

    class Employee
    {
        //Attributes
        private string firstName, lastName;
        private decimal monthlySalary;

        //Constructor
        public Employee(string firstNam, string lastNam, decimal monSalary)
        {
            firstName = firstNam;
            lastName = lastNam;
            monthlySalary = monSalary;
        }

        //Properties
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

        public decimal MonthlySalary
        {
            get { return monthlySalary; }
            set
            {
                if (value >= 0)
                    monthlySalary = value;
            }
        }


        //Method
        public void dispYearSal()
        {
            Console.WriteLine("Employee's Yearly Salary is {0}", monthlySalary * 12);
        }

    }


}
