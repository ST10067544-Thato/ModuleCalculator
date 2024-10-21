using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class SelfStudyHours
    {
        //Method to get and calculate the total self-study hours per week
        public static int getTotalStudyHours(int credits, int weeks, int classhours)
        {
            if (weeks == 0)
            {
                // Handle the case where weeks is zero, e.g., return a default value or throw an exception.
                return 0; // You can change this to a meaningful value.
            }

            return ((credits * 10) / weeks) - classhours;
        }

        //Method to deduct the hours based on the user input
        public static int getRemainingStudyHours(int totalhours, int userinput, int remaininghours)
        {
            remaininghours = totalhours - userinput;

            return remaininghours;
        }
    }
}
