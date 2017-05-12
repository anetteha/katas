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
    }
}
