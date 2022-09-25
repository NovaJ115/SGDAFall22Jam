using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class followPlayer : MonoBehaviour
{
    public Transform playerEric;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        playerEric = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerEric.position;
        if (transform.position.x > playerEric.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
