using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleManager : MonoBehaviour
{
    public List<GameObject> SpawningObject;
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private float delay;
    [SerializeField]
    private bool canSpawn;

    private void Start()
    {
        canSpawn = true;
    }
    private void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(SpawnAgain());
        }
    }
    IEnumerator SpawnAgain()
    {
        canSpawn = false;
        int randomvalue = Random.Range(0, 3);
        Debug.Log(randomvalue);
        Instantiate(obstacle, SpawningObject[randomvalue].transform.position, SpawningObject[randomvalue].transform.rotation);
        yield return new WaitForSeconds(delay);
        canSpawn = true;
    }
}
