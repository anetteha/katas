using System;
using System.Linq;
using CRUDingAConsole;
using CRUDingAConsole.Guys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRUDingAConsoleTest
{
    [TestClass]
    public class GuysHandlerTest
    {
        [TestMethod]
        public void Handler_has_guy_proxy()
        {
            var mock = new RestifyGuysMock();

            var target = new HandleGuys(mock.GetObject());

            Assert.IsNotNull(target.RestifyGuysProxy);
        }

        [TestMethod]
        public void Guy_has_goodness()
        {
            var guy = new Guy();

            var mock = new RestifyGuysMock();

            mock.Guys.Add(guy);

            var target = new HandleGuys(mock.GetObject());

            var actual = target.GetGuy(guy.Id);

            Assert.IsTrue(actual.Goodness > 0);
        }

        [TestMethod]
        public void Guy_has_badness()
        {
            var guy = new Guy();

            var mock = new RestifyGuysMock();

            mock.Guys.Add(guy);

            var target = new HandleGuys(mock.GetObject());

            var actual = target.GetGuy(guy.Id);

            Assert.IsTrue(actual.Badness > 0);
        }
        [TestMethod]
        public void HandleGuys_does_good_deed_and_updates_guy()
        {
            var guy = new Guy(5, 1);

            var mock = new RestifyGuysMock();

            mock.Guys.Add(guy);

            var target = new HandleGuys(mock.GetObject());

            target.GuyDoesGoodDeed(guy.Id);

            var actual = mock.Guys.FirstOrDefault();
            Assert.IsNotNull(actual);
            Assert.AreEqual(6, actual.Goodness);
        }

        [TestMethod]
        public void HandleGuys_get_politicians()
        {
            var guy = new Guy(5, 5);

            var mock = new RestifyGuysMock();

            mock.Guys.Add(guy);

            var target = new HandleGuys(mock.GetObject());

            var politicians = target.GetPoliticians();

            Assert.IsNotNull(politicians);
            Assert.IsTrue(politicians.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Guy_throws_Exception_when_args_are_greater_than_10()
        {
            var guy = new Guy(20, 20);
        }
    }
}
