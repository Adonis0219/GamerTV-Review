using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class SaveButton : MonoBehaviour
    {
        [SerializeField] Button bt; // ゲームオブジェクトのボタン
        [SerializeField] CommonUI commonUI; //　連結するUIスクリプト

        private void Start()
        {
            bt.onClick.AddListener(() =>
            {
                commonUI.Show(UI_TYPE.SAVE);
            });
        }
    }
}
