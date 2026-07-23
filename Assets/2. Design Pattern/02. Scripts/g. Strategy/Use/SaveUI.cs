using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class SaveUI : UIStrategy
    {
        [SerializeField] Button leftBt, rightBt;
        [SerializeField] TextMeshProUGUI leftBtTmp, rightBtTmp;
        [SerializeField] TextMeshProUGUI contentTmp;
        [SerializeField] Sprite saveLeftSpr, saveRightSpr;
        [SerializeField] CommonUI1 commonUI1;

        public override void Execute()
        {
            leftBtTmp.text = "Save";
            leftBt.image.sprite = saveLeftSpr;
            rightBt.image.sprite = saveRightSpr;
            contentTmp.text = "Save the game?";

            leftBt.onClick.AddListener(() =>
            {
                Debug.Log("저장 버튼 동작");
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
