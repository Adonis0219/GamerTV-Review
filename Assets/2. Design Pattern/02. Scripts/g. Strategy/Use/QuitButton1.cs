using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class QuitButton1 : MonoBehaviour
    {
        [SerializeField] Button bt; // ゲームオブジェクトのボタン
        [SerializeField] CommonUI1 commonUI1; //　連結するUIスクリプト
        [SerializeField] UIStrategy strategy; // 自分のUI戦略

        private void Start()
        {
            bt.onClick.AddListener(() =>
            {
                commonUI1.Show(strategy);
            });
        }
    }
}
