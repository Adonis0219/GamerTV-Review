using UnityEngine;

public class h_Ex1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 유니티에서 MonoBehaviour를 상속받은 클래스는 객체를 생성할 때 new 키워드를 사용할 수 없습니다.
        h_Ex h = new h_Ex();

        // 유니티에서는 생성자(Constructor)를 사용하여 객체를 초기화하는 대신, Start()나 Awake() 메서드를 사용하여 초기화 작업을 수행합니다.
    }

    // 유니티에서는 GameObject가 같은 class를 사용하더라도 필드의 값들을 다르게 설정할 수 있다
    // -> 유니티에서는 MonoBehaviour를 상속받은 클래스의 인스턴스는 각각의 GameObject에 부착되어 있기 때문
}
