using System;
using System.Collections;

namespace TenPinBowlingWithFrame
{

    public class TenPinHitStrikeFrame : TenPinFrame
    {

        public TenPinHitStrikeFrame(ArrayList throws)
            : base(throws)
        {
            throws.Add(10);
        }

        override public int PinScore()
        {
            return 10 + FirstBonusBall() + SecondBonusBall();
        }

        override protected int FrameSize()
        {
            return 1;
        }
    }
}
