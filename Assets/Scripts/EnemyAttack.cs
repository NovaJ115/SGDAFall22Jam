using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    private float fireRate = 3f;
    private float nextFire;
    public Transform enemy;
    public GameObject bulletCasing;
    private Transform player;
    private Rigidbody2D rb;
    public AudioSource shoot;
    Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = transform.position - player.transform.position;
        if(Time.time > nextFire && (distance.x < 15f && distance.x > -15f) && (distance.y < 10f && distance.y > -10f))
        {            
            Instantiate(bullet, transform.position, Quaternion.identity);
            shoot.Play();
            GameObject casing = Instantiate(bulletCasing, enemy.position, enemy.rotation);
            rb = casing.GetComponent<Rigidbody2D>();
            rb.AddForce(enemy.up * Random.Range(-1.5f, 1.5f), ForceMode2D.Impulse);
            fireRate = Random.Range(2.7f, 3.3f);
            nextFire = Time.time + fireRate;
        }
        if (Time.time > (nextFire - (fireRate/2)) && rb != null)
        {          
            rb.velocity = Vector2.zero;           
        }
    }


}
