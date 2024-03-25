using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HumanoidClass human = new HumanoidClass();
        HumanoidClass EnemyClass = new EnemyClass();
        HumanoidClass orc = new OrcClass();

        human.Yell();
        EnemyClass.Yell();
        orc.Yell();
    }
}
