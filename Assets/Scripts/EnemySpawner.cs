using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float maxEnemyLeft;
    public float maxEnemyRight;
    public float delayTimer = 1f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 spawnpos = new Vector3(Random.Range(maxEnemyLeft, maxEnemyRight), transform.position.y, transform.position.z);
            int randomIndex = Random.Range(0, 3);
            Instantiate(enemyPrefabs[randomIndex], spawnpos, transform.rotation);
            timer = delayTimer;
        }
    }
}
