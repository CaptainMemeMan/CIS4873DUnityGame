using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelepotyBack : MonoBehaviour
{
    public GameObject player; 
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {

            player.transform.position = new Vector3(198.40f , 38f, 137f);
        }
    }
}
