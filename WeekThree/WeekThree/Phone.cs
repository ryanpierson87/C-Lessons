using System;
namespace WeekThree
{
    public class Phone
    {
        long ContactNumber{get; set;}
        string ContactName { get; set; }
        public double DataMinutes { get; private set; }
        public int OutBoundCalls { get; private set; }
        //short Status { get; private set; }
        //double Monthly_Bill { get; private set; }


        public Phone(string name, long ph_number, short? status)
        {
            ContactName = name;
            ContactNumber = ph_number;
            DataMinutes = 1000;
        }

        public void Call(long phoneNumber)
        {
            double x;
            DateTime callStart = DateTime.Now;
            OutBoundCalls++;
            Console.WriteLine("Now calling " + phoneNumber);
            Console.WriteLine("Press Key to End Call");
            Console.ReadLine();
            DateTime callEnd = DateTime.Now;
            double duration = callEnd.Subtract(callStart).TotalMinutes;
            DataMinutes -= duration;
            Console.WriteLine(string.Format("Call lasted for {0} minutes, you have {1} minutes left", duration, DataMinutes));
        }

        public void MonthlyReset()
        {
            DataMinutes = 1000;
        }

        public string CurrentStatus()
        {
            return string.Format("The Current Status for {0} is {1} outbound calls leaving {2} minutes remaining.", ContactName, OutBoundCalls, DataMinutes);
        }
    }
}
