using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
            moveDirection = direction;
        }

        /**if (target.position.x > transform.position.x)
        {
            SpriteRenderer.flipX;
        }**/
    }
    private void FixedUpdate()
    {
        if(target)
        {
            rb.velocity = new Vector3(moveDirection.x, moveDirection.y) * moveSpeed;
            
        }
    }
}
