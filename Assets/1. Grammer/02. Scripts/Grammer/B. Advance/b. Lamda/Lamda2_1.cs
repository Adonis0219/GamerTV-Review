using UnityEngine;

public class Lamda2_1 : MonoBehaviour
{
    delegate void TestDelegate();

    private void Start()
    {
        TestDelegate test;
        test = () => Debug.Log("TestFunc");

        test.Invoke();
    }
}
