using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawner;
    public float bulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            Shoot(bulletSpawner, bulletSpeed);
        }
    }
    public void Shoot(Transform bulletPosition, float speed)
    {
       var b = Instantiate(bullet, bulletPosition.position, bulletPosition.rotation);
        b.GetComponent<Rigidbody2D>().velocity = bulletPosition.up * speed;
        Kill(b);
    }
    public void Kill(GameObject bullet)
    {
        Destroy(bullet, 3f);
    }
}
