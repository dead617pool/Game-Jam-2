using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleManager : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> SpawningObject = new List<GameObject>();
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private float delay;
    [SerializeField]
    private bool canSpawn;

    private void Start()
    {
        StartCoroutine(SpawnAgain());
    }
    private void Update()
    {
        if (canSpawn)
        {
            canSpawn = false;
            StartCoroutine(SpawnAgain());
            int randomvalue = Random.Range(0, 3);
            Instantiate(obstacle, SpawningObject[randomvalue].transform.position, SpawningObject[randomvalue].transform.rotation);
        }
    }
    IEnumerator SpawnAgain()
    {
        yield return new WaitForSeconds(delay);
        canSpawn = true;
    }
}
