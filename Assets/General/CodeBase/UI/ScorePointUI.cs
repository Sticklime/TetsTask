using CodeBase.Infrastructure;
using CodeBase.Logic;
using General.CodeBase.Infrastructure;
using TMPro;
using UnityEngine;
using Zenject;

namespace General.CodeBase.UI
{
    public class ScorePointUI : MonoBehaviour, ICoroutineRunner
    {
        [SerializeField] private TMP_Text _blueScore;
        [SerializeField] private TMP_Text _redScore;

        private MainMenu _mainMenu;
        private int RedPoints;
        private int BluePoints;

        [Inject]
        public void Construct(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }

        public void AddPoint(PlayerType playerType, int countPoint)
        {
            switch (playerType)
            {
                case PlayerType.Blue:
                    BluePoints += countPoint;
                    _blueScore.text = BluePoints.ToString();
                    break;
                case PlayerType.Red:
                    RedPoints += countPoint;
                    _redScore.text = RedPoints.ToString();
                    break;
            }

            RefreshData();
        }

        private void RefreshData()
        {
            _blueScore.text = BluePoints.ToString();
            _redScore.text = RedPoints.ToString();
        }

        public void CheckWinner(int PointForWin)
        {
            if (BluePoints == PointForWin || RedPoints == PointForWin)
            {
                _mainMenu.gameObject.SetActive(true);
                new SceneLoader(this).Load("Menu");
            }
        }
    }
}