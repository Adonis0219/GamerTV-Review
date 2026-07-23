using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class QuitUI : UIStrategy
    {
        [SerializeField] Button leftBt, rightBt;
        [SerializeField] TextMeshProUGUI leftBtTmp, rightBtTmp;
        [SerializeField] TextMeshProUGUI contentTmp;
        [SerializeField] Sprite quitLeftSpr, quitRightSpr;
        [SerializeField] CommonUI1 commonUI1;

        public override void Execute()
        {
            leftBtTmp.text = "Quit";
            leftBt.image.sprite = quitLeftSpr;
            rightBt.image.sprite = quitRightSpr;
            contentTmp.text = "Quit the game?";

            leftBt.onClick.AddListener(() =>
            {
                Debug.Log("종료 버튼 동작");
                commonUI1.gameObject.SetActive(false);
            });

            rightBt.onClick.AddListener(() =>
            {
                Debug.Log("취소 버튼 동작");
                commonUI1.gameObject.SetActive(false);
            });
        }
    }
}
