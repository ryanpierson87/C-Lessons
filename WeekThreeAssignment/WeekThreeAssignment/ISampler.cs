using System;
namespace WeekThreeAssignment
{
    public interface ISampler
    {
        double Sample(double duration);

        void PadStrike(int padNumber, int velocity);

        Pad[] Pads { get; set; }
    }
}
