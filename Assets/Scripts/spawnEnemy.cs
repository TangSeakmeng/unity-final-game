using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    int x;
    int z;
    int enemyCounter;
    int enemyRemaing=3;
    public int numberOfEnemyToSpawn = 5;


    EnemyManager m_EnemyManager;

    // Start is called before the first frame update
    void Start()
    {
        m_EnemyManager = FindObjectOfType<EnemyManager>();

        enemyRemaing = m_EnemyManager.numberOfEnemiesTotal;

        m_EnemyManager.onRemoveEnemy += OnKillEnemy;

        StartCoroutine(enemyDrop());

    }

    IEnumerator enemyDrop() 
    {
        while (enemyCounter <= numberOfEnemyToSpawn)
        {
            x = Random.Range(-50,-20);
            z = Random.Range(13,31);
            Instantiate(enemy, new Vector3(x, 0, z), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            enemyCounter += 1;
        }
        //enemyRemaing = numberOfEnemyToSpawn;
    }

    void OnKillEnemy(EnemyController enemy, int remaining)
    {
        enemyRemaing = remaining;

        if (enemyRemaing < 1)
        {
            enemyCounter = 0;
            StartCoroutine(enemyDrop());
            numberOfEnemyToSpawn +=1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
