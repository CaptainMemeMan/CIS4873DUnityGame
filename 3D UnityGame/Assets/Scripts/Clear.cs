using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public GameObject ClearMenu;
    public GameObject CrossHair;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            ClearMenu.SetActive(true);
            CrossHair.SetActive(false);
            Time.timeScale = 0f;
            player.SetActive(false);
          
        }
    }
}
