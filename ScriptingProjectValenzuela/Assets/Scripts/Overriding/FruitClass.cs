using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass : MonoBehaviour
{
    public FruitClass()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopeed.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
