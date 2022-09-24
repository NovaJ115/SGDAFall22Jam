using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCasings : MonoBehaviour
{
    public float numCasings = 0f;

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("Casing") && numCasings < 2)
        {
            Destroy(collision.gameObject);
            numCasings++;
        }
    }
}
