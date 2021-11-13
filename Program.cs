using System;
namespace Act1Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Good Morning!, This is Company Automated Time Keeping");
            Console.WriteLine($"Today's Date: {DateTime.Today}");

            Console.WriteLine("Please enter your Company Identification number to log in:");
            String idn = Console.ReadLine();

            TimeSpan RegTimeStart = new TimeSpan(8, 30, 0);
            TimeSpan timeIn = new TimeSpan(8, 31, 0);
            Console.WriteLine($"Your log-in time is recorded! {timeIn}");


            if (timeIn < RegTimeStart)
            {
                Console.WriteLine("You are Early");
            }
            else if (timeIn > RegTimeStart)
            {
                Console.WriteLine("You are late!");
            }


            Console.WriteLine("*********Working Hours*************");
            Console.WriteLine("Good Afternoon!, This is Company Automated Time Keeping");

            TimeSpan timeDuration = new TimeSpan(1, 0, 0);
            TimeSpan lunchOut = new TimeSpan(0, 0, 0);
            Console.WriteLine("Please enter your Company Identification number to log out for lunch:");
            idn = Console.ReadLine();
            Console.WriteLine($"Your time is recorded!{lunchOut}");

            Console.WriteLine("**************Lunch********");


            TimeSpan lunchIn = new TimeSpan(1, 01, 0);
            Console.WriteLine($"Please enter your Company Identification number to log in: {lunchIn}");
            idn = Console.ReadLine();
            Console.WriteLine("Your lunch time duration is recorded!");
            TimeSpan LateIn = timeDuration - (lunchOut + lunchIn);
            if (LateIn > timeDuration)
            {
                Console.WriteLine("You've acquired over time during lunch break");
            }

            Console.WriteLine("*************Working Hours**********");
            Console.WriteLine("Good Afternoon!, Thank You for your Hard Work");

            TimeSpan RegEndTime = new TimeSpan(17, 0, 0);
            TimeSpan timeOut = new TimeSpan(17, 0, 0);
            Console.WriteLine($"Please enter your Company Identification number to log out:{timeOut}");
            idn = Console.ReadLine();
            Console.WriteLine("Your data is recorded, Thank you!");


        }
    }
}




