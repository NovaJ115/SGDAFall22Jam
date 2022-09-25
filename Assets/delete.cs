using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        Delete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Delete()
    {

        
        yield return new WaitForSeconds(2f);
        Destroy(self);

    }
}
