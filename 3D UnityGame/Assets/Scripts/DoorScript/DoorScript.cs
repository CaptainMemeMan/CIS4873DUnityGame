using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class DoorScript : MonoBehaviour
{
    public Target targetCount;
    public GameObject[] numberofTargets; 


    // Update is called once per frame
    void Update()
    {
        if (targetCount.KeepTrack(targetCount.lives) == false)
        {
            Destroy(gameObject); 
        }
    }

   
}
