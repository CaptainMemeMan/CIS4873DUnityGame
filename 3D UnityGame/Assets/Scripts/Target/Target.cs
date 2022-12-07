
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 10f;
    public bool isTargetPractice;
    public float defaulthealth; 
    public float speed; 

    public int targetsDestroyed = 0;

    void Update() 
    {
        moveTarget();
        keepInBounds();
    }
    public void TakeDamage(float amount)
    {
        health -= amount; 
        if(health <= 0f)
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
    void Die()
    {
        if (isTargetPractice)
        {
            health = defaulthealth;
            gameObject.transform.position = new Vector3(Random.Range(-50f,50f), Random.Range(0f, 25f), Random.Range(-50f,50f));
        }
        else
        {
            Destroy(gameObject);
        }
      
    }

    void moveTarget()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        
        
    }

    void keepInBounds()
    {
        if(gameObject.transform.position.x > 55 || gameObject.transform.position.x < -55 || gameObject.transform.position.z < -55 || gameObject.transform.position.z > 55)
        {
           gameObject.transform.position = new Vector3(Random.Range(-50f,50f), Random.Range(0f, 25f), Random.Range(-50f,50f));
           gameObject.transform.LookAt(gameObject.transform.position + new Vector3(Random.Range(-50f,50f),0,0));
        }
    }


   
}
