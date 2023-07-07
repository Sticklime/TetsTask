using CodeBase.Logic;
using TMPro;
using UnityEngine;

namespace CodeBase.UI
{
    public class ScorePointUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _blueScore;
        [SerializeField] private TMP_Text _redScore;

        private int _blueCountPoint;
        private int _redCountPoint;
        
        public void RefreshData(PlayerType playerType, int countPoint)
        {
            switch (playerType)
            {
                case PlayerType.Blue:
                    _blueCountPoint += countPoint;
                    _blueScore.text = _blueCountPoint.ToString();
                    break;
                case PlayerType.Red :
                    _redCountPoint += countPoint;
                    _redScore.text = _redCountPoint.ToString();
                    break;
            }
        }
    }
}