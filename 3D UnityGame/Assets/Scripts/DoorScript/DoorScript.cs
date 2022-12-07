using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Target targetCount;


    // Update is called once per frame
    void Update()
    {
       if (targetCount.KeepTrack(targetCount.lives) == false)
       {
            Destroy(gameObject);
       }
    }

   
}
