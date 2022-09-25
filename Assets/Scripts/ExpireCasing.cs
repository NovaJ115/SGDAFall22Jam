using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpireCasing : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public bool turning;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //rb.transform.Rotate(Vector3.right * 4f);
        StartCoroutine(Turn());
        Destroy(gameObject, 12f);
        
    }

    private void Update()
    {
        if (turning) {
            rb.transform.Rotate(Vector3.forward * 7f);
        }
    }

    public IEnumerator Turn()
    {

        turning = true;

        yield return new WaitForSeconds(Random.Range(1.25f, 1.75f));

        turning = false;
        StopAllCoroutines();

        yield return null;

    }




}
