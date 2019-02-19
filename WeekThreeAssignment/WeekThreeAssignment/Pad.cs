using System;
namespace WeekThreeAssignment
{
    public class Pad : IPad
    {
        public int PadNumber { get; }
        public int LoadedSound{ get; set;}
        public Pad(int number)
        {
            PadNumber = number;
        }

    }
}
