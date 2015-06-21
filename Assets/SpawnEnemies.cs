using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpawnEnemies : MonoBehaviour
{
    public GameObject EnemyToSpawn;
    public int EnemyCountToSpawn = 3;
    public GameObject LookAtObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var enemies = GameObject.FindGameObjectsWithTag("enemy");
        if (enemies.Length < EnemyCountToSpawn)
        {
            for (int i = 0; i < EnemyCountToSpawn - enemies.Length; i++)
            {
                var enemy = Instantiate<GameObject>(EnemyToSpawn);
                enemy.GetComponentInChildren<LookAt>().OrbitObject = LookAtObject;
                enemy.transform.position = new Vector3(0f,Random.Range(-450,450),0f);
                enemy.transform.Rotate(0f, Random.Range(0f,359f), 0f);
            }
        }

    }
}
