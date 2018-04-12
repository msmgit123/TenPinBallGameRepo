using System;
using System.Collections;

namespace TenPinBowlingWithFrame
{

    public class TenPinBowlingGame
    {
        ArrayList throws;
        ArrayList frames;

        public TenPinBowlingGame()
        {
            throws = new ArrayList();
            frames = new ArrayList();
        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            frames.Add(new TenPinOpenFrame(throws, firstThrow, secondThrow));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            frames.Add(new TenPinSpareFrame(throws, firstThrow, secondThrow));
        }

        public void HitStrike()
        {
            frames.Add(new TenPinHitStrikeFrame(throws));
        }

        public void BonusRolling(int roll)
        {
            frames.Add(new BonusRolling(throws, roll));
        }

        public int PinScore()
        {
            int total = 0;
            foreach (TenPinFrame frame in frames)
                total += frame.PinScore();
            return total;
        }
    }
}