using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{


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

}
