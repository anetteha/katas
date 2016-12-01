using System;
using System.Collections.Generic;
using CRUDingAConsole.Guys;

namespace CRUDingAConsole
{
    public class HandleGuys
    {
        public IRestifyGuys<Guy> RestifyGuysProxy { get; set; }

        public HandleGuys(IRestifyGuys<Guy> iRestifyGuys)
        {
            RestifyGuysProxy = iRestifyGuys;
        }

        public Guy GetGuy(Guid guyId)
        {
            return RestifyGuysProxy.GetTheGuy(guyId.ToString());
        }

        public void GuyDoesGoodDeed(Guid guyId)
        {
            var guy = GetGuy(guyId);

            guy.DoGoodDeed();

            RestifyGuysProxy.PutThisGuy(guy);
        }

        public List<Guy> GetPoliticians()
        {
            throw new NotImplementedException();
        }
    }
}
