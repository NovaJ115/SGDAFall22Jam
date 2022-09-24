using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;

    private int xPos;
    private int yPos;
    private int zPos = 0;

    private int minX;
    private int maxX;
    private int minY;
    private int maxY;

    //public float spawnInterval;
    //public float bigSpawnInterval;
    public float enemiesSpawned = 2;
    public float spawnSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        minX = -20;
        maxX = 20;
        minY = -15;
        maxY = 15;
        while (enemiesSpawned > 0)
        {
            xPos = Random.Range(minX, maxX);
            yPos = Random.Range(minY, maxY);

            if(xPos < 11 && xPos > 0)
            {
                xPos = 15;
            }
            else if(xPos >-11 && xPos < 0)
            {
                xPos = -15;
            }
            Instantiate(enemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            
            yield return new WaitForSeconds(Random.Range(.1f, spawnSpeed));


        }
    }

    // Update is called once per frame
    
    
}
