using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyShooting : MonoBehaviour
{
    PlayerMovement playerMovement;
    public float moveSpeed = 7f;

    Rigidbody2D rb;
    public GameObject hurt;
    public GameObject PlayDeath;
    Transform target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Contains("Player") && !playerMovement.invincible)
        {
            playerMovement.numHealth--;
            playerMovement.turnInvincible2();

            Instantiate(hurt);
            Destroy(gameObject);
            if(playerMovement.numHealth == 0)
            {
                Instantiate(PlayDeath);
            }
        }
    }
}
