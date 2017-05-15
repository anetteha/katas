using System;
using System.Collections;
using System.Collections.Generic;

namespace PokerHandGame.PokerHandConsoleApp
{
    public class PokerTable
    {
        public void Initialize(List<PokerHand> pokerHands)
        {
            if (pokerHands.Count == 1)
            {
                throw new Exception("Det er for få spillere din dust!");
            }
            Hands = pokerHands;
        }

        public IList<PokerHand> Hands { get; set; }

        public Winner Play()
        {
            
            return new Winner(){Name = PokerPlayer.Black};
        }
    }
}
