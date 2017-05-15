using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandGame.PokerHandConsoleApp;

namespace PokerHandGame.PokerHandConsoleAppTest
{
    [TestClass]
    public class PokerTableTest
    {
        [TestMethod]
        public void PokerTable_has_a_list_of_players_when_initialized_with_an_empty_list()
        {
            // Arrange
            var target = new PokerTable();

            // Act
            target.Initialize(new List<PokerHand>());

            // Assert
            Assert.IsNotNull(target.Hands);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PokerTable_throws_exception_when_less_than_two_hands()
        {
            // Arrange
            var target = new PokerTable();
            var pokerhandlist = new List<PokerHand>()
            {
                new PokerHand()
                {
                    Name = PokerPlayer.White
                }
            };

            // Act
            target.Initialize(pokerhandlist);
        }

        [TestMethod]
        public void PokerTable_determines_that_Black_wins_with_highest_card()
        {
            // Arrange
            var target = new PokerTable();

            var pokerhandlist = GetTestHand_BlackWins();

            // Act
            target.Initialize(pokerhandlist);
            var actual = target.Play();

            //assert
            Assert.AreEqual(PokerPlayer.Black, actual.Name);
        }

        [TestMethod]
        public void PokerTable_determines_that_White_wins_with_highest_card()
        {
            // Arrange
            var target = new PokerTable();

            var pokerhandlist = GetTestHand_WhiteWins();
            // Act
            target.Initialize(pokerhandlist);
            var actual = target.Play();

            //assert
            Assert.AreEqual(PokerPlayer.Black, actual.Name);
        }

        [TestMethod]
        public void PokerTable_determines_that_hand_wins_with_One_Pair()
        {
            // Arrange
            var target = new PokerTable();

            var pokerhandlist = GetTestHand_WhiteWinsOnePair();
            // Act
            target.Initialize(pokerhandlist);
            var actual = target.Play();

            //assert
            Assert.AreEqual(HandType.OnePair, actual.WinsBy);
        }

        private List<PokerHand> GetTestHand_WhiteWinsOnePair()
        {
            var pokerhandlist = new List<PokerHand>()
            {
                new PokerHand()
                {
                    Name = PokerPlayer.Black,
                    Cards = new List<Card>()
                    {
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Kn} ,
                        new Card(){Color = Colors.Spades, Value = Cardvalues.Two},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Five},
                        new Card(){Color = Colors.Spades, Value = Cardvalues.Seven},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Q}
                    }
                },

                new PokerHand()
                {
                    Name = PokerPlayer.White,
                    Cards = new List<Card>()
                    {
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Ten} ,
                        new Card(){Color = Colors.Clover, Value = Cardvalues.Ten},
                        new Card(){Color = Colors.Clover, Value = Cardvalues.Five},
                        new Card(){Color = Colors.Diamonds, Value = Cardvalues.Eight},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Ace}
                    }
                }
            };
            return pokerhandlist;
        }

        private List<PokerHand> GetTestHand_WhiteWins()
        {
            var pokerhandlist = new List<PokerHand>()
            {
                new PokerHand()
                {
                    Name = PokerPlayer.Black,
                    Cards = new List<Card>()
                    {
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Kn} ,
                        new Card(){Color = Colors.Spades, Value = Cardvalues.Two},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Five},
                        new Card(){Color = Colors.Spades, Value = Cardvalues.Seven},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Q}
                    }
                },

                new PokerHand()
                {
                    Name = PokerPlayer.White,
                    Cards = new List<Card>()
                    {
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.K} ,
                        new Card(){Color = Colors.Clover, Value = Cardvalues.Ten},
                        new Card(){Color = Colors.Clover, Value = Cardvalues.Five},
                        new Card(){Color = Colors.Diamonds, Value = Cardvalues.Eight},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Ace}
                    }
                }
            };
            return pokerhandlist;
        }

        private List<PokerHand> GetTestHand_BlackWins()
        {
            var pokerhandlist = new List<PokerHand>()
            {
                new PokerHand()
                {
                    Name = PokerPlayer.White,
                    Cards = new List<Card>()
                    {
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Kn} ,
                        new Card(){Color = Colors.Spades, Value = Cardvalues.Two},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Five},
                        new Card(){Color = Colors.Spades, Value = Cardvalues.Seven},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Q}
                    }
                },

                new PokerHand()
                {
                    Name = PokerPlayer.Black,
                    Cards = new List<Card>()
                    {
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.K} ,
                        new Card(){Color = Colors.Clover, Value = Cardvalues.Ten},
                        new Card(){Color = Colors.Clover, Value = Cardvalues.Five},
                        new Card(){Color = Colors.Diamonds, Value = Cardvalues.Eight},
                        new Card(){Color = Colors.Hearts, Value = Cardvalues.Ace}
                    }
                }
            };
            return pokerhandlist;
        }
    }
}