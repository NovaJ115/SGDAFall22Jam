using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public PlayerMovement playerMovement;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject player;
    public GameObject PlayDeath;
    public GameObject deathScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.numHealth == 2)
        {
            Destroy(heart3);
        }
        if (playerMovement.numHealth == 1)
        {
            Destroy(heart2);
        }
        if (playerMovement.numHealth == 0)
        {
            deathScreen.SetActive(true);
            Instantiate(PlayDeath);
            Destroy(heart1);
            Destroy(player);
        }
    }
}
