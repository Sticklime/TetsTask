using CodeBase.Logic;

namespace CodeBase.Infrastructure
{
    public interface IGame
    {
        public void StartGame(string name){}
        public void EndGame(PlayerType winner){}
        public void ExitMainMenu(){}
    }
}