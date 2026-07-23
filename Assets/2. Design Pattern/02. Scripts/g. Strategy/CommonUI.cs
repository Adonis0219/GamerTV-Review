using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public enum UI_TYPE
    {
        SAVE, QUIT, REWARD,
    }

    public class CommonUI : MonoBehaviour
    {
        [SerializeField] Button leftBt, rightBt;
        [SerializeField] TextMeshProUGUI leftBtTmp, rightBtTmp;
        [SerializeField] TextMeshProUGUI contentTmp;
        [SerializeField] Sprite saveLeftSpr, saveRightSpr;
        [SerializeField] Sprite quitLeftSpr, quitRightSpr;
        [SerializeField] Sprite rewardLeftSpr;

        void Start() { }

        public void Show(UI_TYPE type)
        {
            SetUITYPE(type);
            gameObject.SetActive(true);
        }

        void SetUITYPE(UI_TYPE type)
        {
            ResetUI();

            switch (type)
            {
                case UI_TYPE.SAVE: SaveListeners(); break;
                case UI_TYPE.QUIT: QuitListeners(); break;
                case UI_TYPE.REWARD: RewardListeners(); break;
            }
        }

        void ResetUI()
        {
            leftBt.onClick.RemoveAllListeners();
            rightBt.onClick.RemoveAllListeners();
            leftBtTmp.color = new Color32(50, 50, 50, 255);
            rightBtTmp.color = new Color32(50, 50, 50, 255);
            rightBt.gameObject.SetActive(true);
        }

        void SaveListeners()
        {
            leftBtTmp.text = "Save";
            leftBt.image.sprite = saveLeftSpr;
            rightBt.image.sprite = saveRightSpr;
            contentTmp.text = "Save the game?";

            leftBt.onClick.AddListener(() =>
            {
                Debug.Log("저장 버튼 동작");
                gameObject.SetActive(false);
            });

            rightBt.onClick.AddListener(() =>
            {
                Debug.Log("취소 버튼 동작");
                gameObject.SetActive(false);
            });
        }

        void QuitListeners()
        {
            leftBtTmp.text = "Quit";
            leftBt.image.sprite = quitLeftSpr;
            rightBt.image.sprite = quitRightSpr;
            contentTmp.text = "Quit the game?";

            leftBt.onClick.AddListener(() =>
            {
                Debug.Log("종료 버튼 동작");
                gameObject.SetActive(false);
            });

            rightBt.onClick.AddListener(() =>
            {
                Debug.Log("취소 버튼 동작");
                gameObject.SetActive(false);
            });
        }

        void RewardListeners()
        {
            leftBtTmp.text = "OK";
            leftBt.image.sprite = rewardLeftSpr;
            contentTmp.text = "+ 100exp";

            leftBt.onClick.AddListener(() =>
            {
                Debug.Log("종료 버튼 동작");
                gameObject.SetActive(false);
            });
        }
    }
}
