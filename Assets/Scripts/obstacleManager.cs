using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleManager : MonoBehaviour
{
    public List<GameObject> SpawningObject;
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private float xDelay;
    [SerializeField]
    private float yDelay;
    [SerializeField]
    private float zDelay;
    [SerializeField]
    private bool canSpawn;
    [SerializeField]
    Speed speed;
    [SerializeField]
    private float coeff;
    [SerializeField]
    private float xSpeed;
    [SerializeField]
    private float ySpeed;

    private void Awake()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
    }
    private void Start()
    {
        canSpawn = true;
    }
    private void Update()
    {
        if (canSpawn)
        {
            canSpawn = false;
            if (speed.velocity.x < xSpeed)
            {
                StartCoroutine(SpawnAgain(xDelay));

            }
            else
            {
                StartCoroutine(SpawnAgain(yDelay / (speed.velocity.x)));

            }
        }
    }
    IEnumerator SpawnAgain(float time)
    {
   
         yield return new WaitForSeconds(time);
        


        int spawnPointObstacle1 = UnityEngine.Random.Range(0, 3);
        int spawnPointObstacle2 = UnityEngine.Random.Range(0, 3);
        Instantiate(obstacle, SpawningObject[spawnPointObstacle1].transform.position, SpawningObject[spawnPointObstacle1].transform.rotation);
        if (spawnPointObstacle2 !=spawnPointObstacle1) 
            Instantiate(obstacle, SpawningObject[spawnPointObstacle2].transform.position, SpawningObject[spawnPointObstacle2].transform.rotation);

        canSpawn = true;
    }

}
