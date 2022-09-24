using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
<<<<<<< Updated upstream


    void Start()
    {
        Destroy(gameObject, 3f);
        //StartCoroutine(DestroBullet());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    /**
    public IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(3f);
        Destroy(GameObject);
    }
    **/

=======
    float moveSpeed = 7f;

    Rigidbody2D rb;

    Transform target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }
>>>>>>> Stashed changes
}
