using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int levelNum = 1;
    private bool levelCompleted = false;
    private float spawnTimer = 2;

    public GameObject smallShip;
    public GameObject mediumShip;
    public GameObject largeShip;
    private GameObject[] shipList;

    private List<GameObject> currentEnemyPool;
    private List<GameObject> nextEnemyPool;


    // Start is called before the first frame update
    void Start()
    {
        shipList = new GameObject[3];
        shipList[0] = smallShip;
        shipList[1] = mediumShip;
        shipList[2] = largeShip;

        currentEnemyPool = new List<GameObject>();
        nextEnemyPool = new List<GameObject>();

        CreatePool(levelNum);
        InvokeRepeating("SpawnShip", spawnTimer, Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        //-4.7 -> 4.7

        if (currentEnemyPool.Count == 0)
        {
            NewLevel();
        }
    }

    private void CreatePool(int level)
    {
        if (level == 1 || level == 2 || level == 3)
        {
            nextEnemyPool.Clear();
            for (int i = 0; i < 5 * levelNum; i++)
            {
                GameObject temp = Instantiate(shipList[level]);
                temp.SetActive(false);
                nextEnemyPool.Add(temp);
            }
            //levelCompleted = false;
            currentEnemyPool = nextEnemyPool;
            
        }
        else if(level > 3)
        {
            nextEnemyPool.Clear();
            for (int i = 0; i < 5 * levelNum; i++)
            {
                int shipRange = Random.Range(1, 3);
                GameObject temp = Instantiate(shipList[shipRange]);
                temp.SetActive(false);
                nextEnemyPool.Add(temp);
            }
            //levelCompleted = false;
            currentEnemyPool = nextEnemyPool;
            nextEnemyPool.Clear();
        }
    }

    private void NewLevel()
    {
        levelNum += 1;
        CreatePool(levelNum);
    }

    public GameObject GetShip()
    {
        for (int i = 0; i < currentEnemyPool.Count; i++)
        {
            if (!currentEnemyPool[i].activeInHierarchy)
            {
                return currentEnemyPool[i];
            }
        }
        return null;
    }

    private void SpawnShip()
    {
        spawnTimer = 2;
        GameObject temp = GetShip();
        temp.transform.position = new Vector3(Random.Range(-4.7f, 4.7f), 5.75f, 0);
        temp.SetActive(true);
    }
}
