using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    // get firepoint position
    public Transform firePoint;

    //Get Bullet Prefab
    public GameObject BulletPrefab;

    //Set Speed
    public float speed = 20f;

    //Get AudioSource
    public AudioSource shootSound;

    // Update is called once per frame
    void Update()
    {
        //Fire
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    void Shoot()
    {
        GameObject bullet =Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * speed, ForceMode2D.Impulse);

        //Play Sound
        shootSound.Play();
    }
}
