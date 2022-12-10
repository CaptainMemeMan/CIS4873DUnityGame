using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem muzzleflash;
    public float impactForce = 100f; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            Shoot();
        }
    }
    void Shoot()
    {
        muzzleflash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            Target target = hit.transform.GetComponent<Target>();
            PlatformTarget target1 = hit.transform.GetComponent<PlatformTarget>();
            NonMovingTarget target2 = hit.transform.GetComponent<NonMovingTarget>();
            if (target != null)
            {

                target.TakeDamage(damage);

            } else if (target1 != null)
            {
                target1.TakeDamage(damage);
            } else if (target2 != null)
            {
                target2.TakeDamage(damage);
            }
        } 
    }
}
