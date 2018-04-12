using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPinBowlingWithFrame
{

    public class BonusRolling : TenPinFrame
    {

        public BonusRolling(ArrayList throws, int firstThrow)
            : base(throws)
        {
            throws.Add(firstThrow);
        }

        override public int PinScore()
        {
            return 0;
        }

        override protected int FrameSize()
        {
            return 0;
        }
    }
}