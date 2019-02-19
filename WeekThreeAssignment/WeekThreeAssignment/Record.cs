using System;
namespace WeekThreeAssignment
{
    public static class Record
    {
        public static void Play(string track)
        {
            Console.Write("The song " + track + " is playing");
        }

        public static double SampleSound(double audio)
        {
            return audio * 3.14;
        }
    }
}
