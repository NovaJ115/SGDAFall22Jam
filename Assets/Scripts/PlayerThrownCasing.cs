using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrownCasing : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 0.1f);
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
