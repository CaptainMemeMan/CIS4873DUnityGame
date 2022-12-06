
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public bool isTargetPractice;
    public float defaulthealth; 

    public void TakeDamage(float amount)
    {
        health -= amount; 
        if(health <= 0f)
        {
            Die();
        }

    }
    void Die()
    {
        if (isTargetPractice)
        {
            health = defaulthealth;
            gameObject.transform.position = new Vector3(Random.Range(-50f,50f), Random.Range(1f, 10f), Random.Range(-50f,50f));
        }
        else
        {
            Destroy(gameObject);
        }
      
    }
}
