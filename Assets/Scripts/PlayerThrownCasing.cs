using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrownCasing : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
        //StartCoroutine(DestroBullet());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.tag.Contains("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Contains("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    /**
    public IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(3f);
        Destroy(GameObject);
    }
    **/

}
