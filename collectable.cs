using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool hit = false; 

    // score is for key coz idk how else to do it uhh
    public int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player")) // only if Player tag, then
        {
            hit = true;
        }
    }

    void Update()
    {
        if (hit == true)
        {
            Destroy(gameObject);
            score += 1;
        }
    }
}
