using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPlayer : MonoBehaviour
{
    public static int playerCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerCount++;
    }
}
