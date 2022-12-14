
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 10f;
    public bool isTargetPractice;
    public float defaulthealth; 
    public float speed;
    public float lives;
    public bool isAlive = true; 

    public int targetsDestroyed = 0;

    public bool DoNotMove;

    void Update() 
    {
        if (DoNotMove == false)
        {
            moveTarget();

            keepInBounds();
        }
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
    public void Die()
    {
        if (isTargetPractice)
        {
            health = defaulthealth;
            gameObject.transform.position = new Vector3(Random.Range(-50f,50f), Random.Range(0f, 25f), Random.Range(-50f,50f));
            KeepTrack(lives);
            lives--;
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
    public bool KeepTrack(float lives)
    {
        Debug.Log(lives);
        Debug.Log("Much lvoe from Morjsioadjsioadsa");
        if (lives <= 0){
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
