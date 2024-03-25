using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SomeOtherMethodClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeMethodClass myClass = new SomeMethodClass();

        myClass.Add (1, 2);
        myClass.Add("Hello", "World");
    }
}
