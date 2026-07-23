using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class QuitButton : MonoBehaviour
    {
        [SerializeField] Button bt; // ボタンのゲームオブジェクト
        [SerializeField] CommonUI commonUI; //　連結するUIスクリプト

        private void Start()
        {
            bt.onClick.AddListener(() =>
            {
                commonUI.Show(UI_TYPE.QUIT);
            });
        }
    }
}
