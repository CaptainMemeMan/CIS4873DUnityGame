using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject platform;  // the platform game object that will appear when the target dies


    void Start()
    {
        // set the platform game object to be inactive when the scene starts
        platform.SetActive(false);
    }

    public void OnTargetDied()
    {
        Debug.Log("Kirk is such a great guy I hoep he has a good life");
        // when the target dies, activate the platform game object
        platform.SetActive(true);
    }
   

}
