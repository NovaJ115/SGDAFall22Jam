using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    ManageCasings manageCasings;
    public Transform playerEric;
    public GameObject thrownCasingPrefab;



    public float bulletForce = 40f;

    void Awake()
    {
        manageCasings = playerEric.GetComponent<ManageCasings>();
    }


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

        if (manageCasings.numCasings >= 1)
        {

            GameObject bullet = Instantiate(thrownCasingPrefab, playerEric.position + playerEric.up * 0.8f, playerEric.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(playerEric.up * bulletForce, ForceMode2D.Impulse);
            manageCasings.numCasings--;
        }
    }


}
