using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class CommonUI1 : MonoBehaviour
    {
        [SerializeField] Button leftBt, rightBt;
        [SerializeField] TextMeshProUGUI leftBtTmp, rightBtTmp;
        [SerializeField] TextMeshProUGUI contentTmp;

        public void Show(UIStrategy strategy)
        {
            ResetUI();
            strategy.Execute();
        }

        void ResetUI()
        {
            leftBt.onClick.RemoveAllListeners();
            rightBt.onClick.RemoveAllListeners();
            leftBtTmp.color = new Color32(50, 50, 50, 255);
            rightBtTmp.color = new Color32(50, 50, 50, 255);
            rightBt.gameObject.SetActive(true);
        }
    }
}
