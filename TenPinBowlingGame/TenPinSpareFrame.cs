using System;
using System.Collections;

namespace TenPinBowlingWithFrame
{

    public class TenPinSpareFrame : TenPinFrame
    {

        public TenPinSpareFrame(ArrayList throws, int firstThrow, int secondThrow)
            : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int PinScore()
        {
            return 10 + FirstBonusBall(); ;
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}
