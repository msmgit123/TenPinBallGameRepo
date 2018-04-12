using System;
using System.Collections;

namespace TenPinBowlingWithFrame
{

    public class TenPinOpenFrame : TenPinFrame
    {

        public TenPinOpenFrame(ArrayList throws, int firstThrow, int secondThrow)
            : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int PinScore()
        {
            return (int)throws[startingThrow] + (int)throws[startingThrow + 1];
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}