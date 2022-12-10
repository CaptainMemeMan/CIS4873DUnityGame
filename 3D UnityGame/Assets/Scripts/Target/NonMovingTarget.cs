using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonMovingTarget : MonoBehaviour
{
    public float health = 10f;
    public bool isTargetPractice;
    public float defaulthealth;
    public float lives;
    public bool isAlive = true;

    public int targetsDestroyed = 0;

    public PlatformScript platformScript;

    void Update()
    {
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
            // targetsDestroyed++;
            //if(targetsDestroyed == 10) {
            //   if(gameObject.tag == "Door") {
            //      gameObject.transform.LookAt(gameObject.transform.position + new Vector3(0,70,0));
            //  }

            // }
        }

    }
    public void Die()
    {
        if (isTargetPractice)
        {
            health = defaulthealth;
            KeepTrack(lives);
            lives--;
        }
        else
        {
            Destroy(gameObject);
        }

    }

   

  
    public bool KeepTrack(float lives)
    {
        if (lives <= 0)
        {
            platformScript.OnTargetDied();

            isAlive = false;
            this.gameObject.SetActive(false);
            return isAlive;

        }
        else
        {
            isAlive = true;
            return isAlive;
        }

    }
}
