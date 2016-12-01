using System.Collections.Generic;
using System.Linq;
using CRUDingAConsole;
using CRUDingAConsole.Guys;
using Moq;

namespace CRUDingAConsoleTest
{
    public class RestifyGuysMock
    {
        public RestifyGuysMock()
        {
            Guys = new List<Guy>();
        }

        public List<Guy> Guys { get; set; }

        public IRestifyGuys<Guy> GetObject()
        {
            var mock = new Mock<IRestifyGuys<Guy>>();

            mock.Setup(x => x.GetTheGuy(It.IsAny<string>())).Returns<string>(GetAGuy);
            mock.Setup(x => x.PostANewGuy(It.IsAny<Guy>())).Callback<Guy>(x => Guys.Add(x));
            mock.Setup(x => x.DeleteTheGuy(It.IsAny<string>())).Callback<string>(x => Guys.Remove(Guys.FirstOrDefault(y => y.Id.ToString().Equals(x))));
            mock.Setup(x => x.PutThisGuy(It.IsAny<Guy>())).Callback<Guy>(ReplaceGuy);
            
            return mock.Object;
        }

        private void ReplaceGuy(Guy obj)
        {
            Guys.Remove(Guys.FirstOrDefault(y => y.Id.Equals(obj.Id)));
            Guys.Add(obj);
        }

        private Guy GetAGuy(string s)
        {
            return Guys.FirstOrDefault();
        }
    }
}