using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : HumanoidClass
{
    // hides humanoid version
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
