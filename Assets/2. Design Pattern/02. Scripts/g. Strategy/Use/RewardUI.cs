using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class RewardUI : UIStrategy
    {
        [SerializeField] Button leftBt, rightBt;
        [SerializeField] TextMeshProUGUI leftBtTmp, rightBtTmp;
        [SerializeField] TextMeshProUGUI contentTmp;
        [SerializeField] Sprite rewardLeftSpr;
        [SerializeField] CommonUI1 commonUI1;

        public override void Execute()
        {
            leftBtTmp.text = "OK";
            leftBt.image.sprite = rewardLeftSpr;
            contentTmp.text = "+ 100exp";

            leftBt.onClick.AddListener(() =>
            {
                Debug.Log("종료 버튼 동작");
                commonUI1.gameObject.SetActive(false);
            });
        }
    }
}
