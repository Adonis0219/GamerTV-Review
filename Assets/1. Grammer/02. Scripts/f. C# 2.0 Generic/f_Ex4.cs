using System.Collections.Generic;
using UnityEngine;

public class f_Ex4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // HashTable의 제네릭 버전인 Dictionary<TKey, TValue> 클래스입니다.
        // HashTable<object, object>
        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict["하나"] = "one"; 
        dict["둘"] = "two";
        dict["셋"] = "three";
        dict["넷"] = "four";
        dict["다섯"] = "five";

        Debug.Log(dict["하나"]);
        Debug.Log(dict["둘"]);
        Debug.Log(dict["셋"]);
        Debug.Log(dict["넷"]);
        Debug.Log(dict["다섯"]);
    }
}
