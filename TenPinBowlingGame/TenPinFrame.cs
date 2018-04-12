using System;
using System.Collections;

namespace TenPinBowlingWithFrame
{

    abstract public class TenPinFrame
    {
        protected ArrayList throws;
        protected int startingThrow;

        public TenPinFrame(ArrayList throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }

        abstract public int PinScore();
        abstract protected int FrameSize();

        protected int FirstBonusBall()
        {
            return (int)throws[startingThrow + FrameSize()];
        }

        protected int SecondBonusBall()
        {
            return (int)throws[startingThrow + FrameSize() + 1];
        }
    }
}
