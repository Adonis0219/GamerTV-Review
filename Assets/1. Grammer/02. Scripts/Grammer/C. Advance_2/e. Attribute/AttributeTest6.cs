using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class AttributeTest6 : MonoBehaviour
{
    [FindComponents("Target1")]public Rigidbody rb;
    [FindComponents("Target1")]public BoxCollider bc;
    [FindComponents("Target2")]public AudioSource audi;
    [FindComponents("Target3", "Target4")] public AudioSource[] audiArr = new AudioSource[2];
    [FindComponents("Target5", "Target6")] public List<Rigidbody> rbList = new List<Rigidbody>();


    private void Awake()
    {
        Util.InjectComponent3(this);
    }
}
