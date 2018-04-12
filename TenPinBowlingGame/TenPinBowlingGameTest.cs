using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TenPinBowlingWithFrame
{

    [TestClass]
    public class TenPinBowlingGameTest
    {
        TenPinBowlingGame game = new TenPinBowlingGame();
        [TestMethod]
        public void AllHitStrike()
        {
            //TenPinBowlingGame game = new TenPinBowlingGame();
            for (int i = 0; i < 10; i++)
            {
                game.HitStrike();
                game.BonusRolling(10);
                game.BonusRolling(10);
            }
            Assert.AreEqual(300, game.PinScore());
        }

        [TestMethod]
        //9-9-9-9-9-9-9-9-9-9
        public void Pins_9090909090909090909()
        {
            //TenPinBowlingGame game = new TenPinBowlingGame();
            for (int i = 0; i < 10; i++)
                game.OpenFrame(9, 0);

            Assert.AreEqual(90, game.PinScore());
        }

        [TestMethod]
        //Alternating HitStrike
        public void Pins_Alternating_HitStrike()
        {
            //TenPinBowlingGame game = new TenPinBowlingGame();
            for (int i = 0; i < 10; i++)
            {
                game.Spare(8, 2); //spare /5/5/5/5/5/5/5/5/5/5/5
                game.BonusRolling(5);
            }
            System.Diagnostics.Debug.WriteLine(game.PinScore());
        }
    }
}
