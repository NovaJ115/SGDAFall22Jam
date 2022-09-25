using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnemyKill : MonoBehaviour
{

    public AudioSource die;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        die.Play();
    }
}
