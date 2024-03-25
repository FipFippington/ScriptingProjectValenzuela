using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcClass : EnemyClass
{
    //Hides enemy version
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
