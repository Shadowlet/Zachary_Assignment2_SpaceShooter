using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float lifeTimer;

    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = 4;
    }

    private void OnEnable()
    {
        lifeTimer = 4;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer -= Time.deltaTime;

        if (lifeTimer <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    
}
