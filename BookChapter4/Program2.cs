using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter4
{
    class Exercise4_14
    {
        static void Main(string[] args)
        {
            Date a = new Date(2, 19, 2018);
            a.DisplayDate();

        }

        class Date
        {
            public int Month
            {
                get; set;
            }

            public int Day
            {
                get; set;
            }

            public int Year
            {
                get; set;
            }

            public Date(int month, int day, int year)
            {
                Month = month;
                Day = day;
                Year = year;
            }

            public void DisplayDate()
            {
                Console.WriteLine("{0}/{1}/{2}", Month, Day, Year);
            }

        }





    }
    
    


}
