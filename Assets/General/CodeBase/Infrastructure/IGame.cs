using CodeBase.Logic;

namespace General.CodeBase.Infrastructure
{
    public interface IGame
    {
        public void StartGame(string name){}
        public void EndGame(PlayerType winner){}
        public void ExitMainMenu(){}
    }
}