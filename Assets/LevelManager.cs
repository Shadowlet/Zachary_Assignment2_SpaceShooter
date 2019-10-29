using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int levelNum = 1;
    private bool levelCompleted = false;

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

        CreatePool(levelNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreatePool(int level)
    {
        if (level == 1 || level == 2 || level == 3)
        {
            for (int i = 0; i < 5 * levelNum; i++)
            {
                GameObject temp = Instantiate(shipList[level]);
                temp.SetActive(false);
                nextEnemyPool.Add(temp);
            }
            levelCompleted = false;
        }
        else if(level > 3)
        {
            for (int i = 0; i < 5 * levelNum; i++)
            {
                int shipRange = Random.Range(1, 3);
                GameObject temp = Instantiate(shipList[shipRange]);
                temp.SetActive(false);

            }
            levelCompleted = false;
        }
    }

    private void NewLevel()
    {

    }
}
