using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    // attach this script to the trigger you want to activate this script, like a door

    void OnTriggerEnter(Collider other)
    {
        if (score == 1)
        {
            SceneManager.GetActiveScene().buildIndex + 1;
            score = 0;
        }
    }
}
