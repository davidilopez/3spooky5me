using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

    bool isSpawning = false;
    public GameObject[] enemies;  // Array of enemy prefabs.

    private float minTime = masterSpawnerControls.minTime;
    private float maxTime = masterSpawnerControls.maxTime;

    void Start()
    {
        GameObject MasterSpawner = GameObject.Find("MasterSpawner");


    }
    IEnumerator SpawnObject(int index, float seconds)
    {
        Debug.Log("Waiting for " + seconds + " seconds");

        yield return new WaitForSeconds(seconds);
        Instantiate(enemies[index], transform.position, transform.rotation);

        //We've spawned, so now we could start another spawn     
        isSpawning = false;
    }

    void Update()
    {
        //We only want to spawn one at a time, so make sure we're not already making that call
        if (!isSpawning)
        {
            isSpawning = true; //Yep, we're going to spawn
            int enemyIndex = Random.Range(0, enemies.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
        }
    }
}