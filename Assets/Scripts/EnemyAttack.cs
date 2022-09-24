using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    public float fireRate = 1f;
    private float nextFire;
    public Transform enemy;
    public GameObject bulletCasing;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFire)
        {            
            Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject casing = Instantiate(bulletCasing, enemy.position, enemy.rotation);
            rb = casing.GetComponent<Rigidbody2D>();
            rb.AddForce(enemy.up * Random.Range(-1.0f, 1.0f), ForceMode2D.Impulse);
            nextFire = Time.time + fireRate;
        }
        if (Time.time > (nextFire - (fireRate/2)) && rb != null)
        {          
            rb.velocity = Vector2.zero;           
        }
    }


}
