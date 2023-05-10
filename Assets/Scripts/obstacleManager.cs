using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleManager : MonoBehaviour
{
    public List<Bonus> spawningBonus = new();
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
    [SerializeField]
    private int ForceDelay = 0;

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
            var t = xDelay;

            if (ForceDelay == 1)
            {
                t += 1;
                ForceDelay++;
            }else
            {
                 t = xDelay;
            }

            if(ForceDelay<1) ForceDelay++;

            if (speed.velocity.x < xSpeed)
            {
                StartCoroutine(SpawnAgain(t));

            }
            else
            {
                StartCoroutine(SpawnAgain(yDelay / (speed.velocity.x)));

            }
        }
    }

    private List<Bonus> GetUnlockedBonus()
    {
        List<Bonus> bonus = new();

        foreach(var bonu in spawningBonus)
        {
            if(bonu.IsUnlocked(Mathf.FloorToInt(speed.distance)))
                bonus.Add(bonu);
        }

        return bonus;
    }

    private Bonus GetRandomBonusInAvailable()
    {
        var bonusList = GetUnlockedBonus();

        var index = UnityEngine.Random.Range(0, bonusList.Count);
        if(bonusList.Count > index)
            return bonusList[index];
        return null;
    }

    IEnumerator SpawnAgain(float time)
    {
         yield return new WaitForSeconds(time);

        var availableBonus = GetUnlockedBonus();
    IEnumerator SpawnAgain(float time)
    {
   
         yield return new WaitForSeconds(time);
        
        int spawnPointObstacle1 = UnityEngine.Random.Range(0, 3);
        int spawnPointObstacle2 = UnityEngine.Random.Range(0, 3);
        Instantiate(obstacle, SpawningObject[spawnPointObstacle1].transform.position, SpawningObject[spawnPointObstacle1].transform.rotation);

        if (UnityEngine.Random.Range(0,10) < 1)
        {
            var bonus = GetRandomBonusInAvailable();
            if (spawnPointObstacle2 != spawnPointObstacle1 && bonus != null)
                Instantiate(bonus, SpawningObject[spawnPointObstacle2].transform.position, SpawningObject[spawnPointObstacle2].transform.rotation);
        }
        else
        {
        
            if (spawnPointObstacle2 != spawnPointObstacle1)
                Instantiate(obstacle, SpawningObject[spawnPointObstacle2].transform.position, SpawningObject[spawnPointObstacle2].transform.rotation);

        }

        if (spawnPointObstacle2 !=spawnPointObstacle1) 
            Instantiate(obstacle, SpawningObject[spawnPointObstacle2].transform.position, SpawningObject[spawnPointObstacle2].transform.rotation);

        canSpawn = true;
    }
    IEnumerator Delay(float wait)
    { yield return new WaitForSeconds(wait); }

}
