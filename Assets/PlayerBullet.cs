using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private GameObject bullet;
    private List<GameObject> bulletPool;

    private int sizeOfList;

    private bool canListGrow;

    // Start is called before the first frame update
    void Start()
    {
        bulletPool = new List<GameObject>();
        sizeOfList = 30;
        canListGrow = true;
        AddBulletsToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddBulletsToList()
    {
        for (int i = 0; i < sizeOfList; i++)
        {
            GameObject temp = Instantiate(bullet);
            temp.SetActive(false);
            bulletPool.Add(temp);
        }
    }

    public GameObject GetBullet()
    {
        for (int i = 0; i < bulletPool.Count; i++)
        {
            if (!bulletPool[i].activeInHierarchy)
            {
                return bulletPool[i];
            }
        }

        if (canListGrow)
        {
            GameObject temp = Instantiate(bullet);
            temp.SetActive(false);
            bulletPool.Add(temp);
            return temp;

        }

        return null;
    }
}
