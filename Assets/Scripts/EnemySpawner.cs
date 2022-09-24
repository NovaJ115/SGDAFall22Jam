using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject spawnArea;

    public float spawnInterval;
    public float bigSpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Its working");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Its working");

    }

    public IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-5f, 5), 0), Quaternion.identity);
    }
    
}
