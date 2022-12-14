
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


    private float PosX;
    private float PosY;
    private float PosZ;

    void Start()
    {
        PosX = gameObject.transform.position.x;
        PosY = gameObject.transform.position.y;
        PosZ = gameObject.transform.position.z;
    }

    void Update()
    {
        
        if (DoNotMove == false)
        {
            moveTarget();

            keepInBounds();
        }
        Debug.Log(PosX);
        Debug.Log(PosY);
        Debug.Log(PosZ);
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
            gameObject.transform.position = new Vector3(Random.Range((PosX - 33), (PosX + 33)), Random.Range(PosY, (PosY + 27)), Random.Range((PosZ - 33), (PosZ + 33)));
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
        if (gameObject.transform.position.x > (PosX + 38) || gameObject.transform.position.x < (PosX - 38) || gameObject.transform.position.z < (PosZ - 38) || gameObject.transform.position.z > (PosZ + 38) || gameObject.transform.position.y > (PosY + 27) || gameObject.transform.position.y < (PosY))
        {
            gameObject.transform.position = new Vector3(Random.Range((PosX - 33), (PosX + 33)), Random.Range(PosY, (PosY + 27)), Random.Range((PosZ - 33), (PosZ + 33)));
            gameObject.transform.LookAt(new Vector3(Random.Range((PosX - 33), (PosX + 33)), Random.Range(PosY, (PosY + 27)), Random.Range((PosZ - 33), (PosZ + 33))));
        }
    }
    public bool KeepTrack(float lives)
    {
        Debug.Log(lives);
        Debug.Log("Much lvoe from Morjsioadjsioadsa");
        if (lives <= 0)
        {
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
