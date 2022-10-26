using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Awsome

        /* Oh
         * wowza 
         * multiple lines */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I strongly dislike the hit game Amoung Us");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
