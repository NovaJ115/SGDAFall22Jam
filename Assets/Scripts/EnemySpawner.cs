using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    private Transform player;

    private int xPos;
    private int yPos;
    private int zPos = 0;

    private float minX;
    private float maxX;
    private float minY;
    private float maxY;

    //public float spawnInterval;
    //public float bigSpawnInterval;
    public float enemiesSpawned = 2;
    public float spawnSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        
        while (enemiesSpawned > 0)
        {
            minX = player.transform.position.x - 25f;
            maxX = player.transform.position.x + 25;
            minY = player.transform.position.y - 25;
            maxY = player.transform.position.y + 25;
            Debug.Log(player.transform.position.x);

            xPos = (int)Random.Range(minX, maxX);
            yPos = (int)Random.Range(minY, maxY);

            if(xPos < 25 && xPos > 0)
            {
                xPos = 25;
            }
            else if(xPos >-25 && xPos <= 0)
            {
                xPos = -25;
            }
            Instantiate(enemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            
            yield return new WaitForSeconds(Random.Range(.5f, spawnSpeed));


        }
    }
}
