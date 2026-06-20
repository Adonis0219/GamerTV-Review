using System.Data.Common;
using UnityEngine;

public class i_Ex1 : MonoBehaviour
{
    public class Manager
    {
        // new 키워드와 생성자를 이용해서 인스턴스 생성
        static public Manager instance = new Manager();

        public int score = 0;

        private Manager() { } // 생성자를 private으로 선언

        public void AddScore()
        {
            score++;
        }

        public void SubScore()
        {
            score--;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 생성자가 private이므로 더 이상의 인스턴스는 생성 불가능하다
        //  Manager manager = new Manager();

        Manager.instance.AddScore();
        Manager.instance.SubScore();
        Manager.instance.SubScore();

        Debug.Log(Manager.instance.score);
    }
}
