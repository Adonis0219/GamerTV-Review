using UnityEngine;

public class d_Ex2 : MonoBehaviour
{
    class Orc { }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Orc orc = new Orc();
        Debug.Log(orc.ToString());
    }
}
