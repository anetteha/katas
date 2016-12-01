using CRUDingAConsole.Guys;

namespace CRUDingAConsole
{
    public interface IRestifyGuys<T>
    {
        T GetTheGuy(string id);
        void PutThisGuy(T littleGuy);
        void PostANewGuy(T littleGuy);
        void DeleteTheGuy(string id);
    }
}
