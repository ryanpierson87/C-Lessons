using System;
namespace WeekThreeAssignment
{
    public class MPC : ISampler
    {
        public Pad[] Pads { get; set; } = new Pad[16];



        public double Sample(double duration)
        {
            return Record.SampleSound(duration);
        }

        public double ActiveSample
        {
            get
            {
                return ActiveSample;
            }
            set
            {
                ActiveSample = value * 314;
            }
        }

        public void KitCreation()
        {
            foreach()
        }


        public void PadStrike(int padNumber, int velocity)
        {
            Console.Write("Now playing Pad " + padNumber + " with " + velocity + " force.");
        }
    }
}
