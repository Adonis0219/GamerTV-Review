using System.Collections;
using UnityEngine;

public static class GameObjectExtension
{
    // GameObject와 모든 자식 객체의 활성화 상태를 설정하는 확장 메서드
    public static void SetActiveRecursive(this GameObject gameObject, bool isActive)
    {
        gameObject.SetActive(isActive);

        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActiveRecursive(isActive);
        }
    }
}

public class ExtensionTest2 : MonoBehaviour 
{
    public GameObject go;

    WaitForSeconds wfs = new WaitForSeconds(2.0f);

    private IEnumerator Start()
    {
        while (true)
        {
            go.SetActiveRecursive(false);
            yield return wfs;
            go.SetActiveRecursive(true);
            yield return wfs;
        }
    }
}
