﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public GameObject bullet;

    private BulletPool bulletPool;
    Rigidbody2D my_Rigidbody;

    public float score;
    private float shootTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    private void OnEnable()
    {
        bulletPool = GameObject.Find("EnemyBulletManager").GetComponent<BulletPool>();

        my_Rigidbody = GetComponent<Rigidbody2D>();
        MoveShip();
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0)
        {
            ShootBullet();
        }

    }

    private void ShootBullet()
    {
        shootTimer = 1.5f;

        Debug.Log("Shooting");
        GameObject temp = bulletPool.GetBullet();
        temp.transform.position = transform.position;
        temp.SetActive(true);
        temp.GetComponent<Rigidbody2D>().AddForce(Vector3.down * 200);
    }

    private void MoveShip()
    {
        my_Rigidbody.AddForce(Vector3.down * 100);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet_player")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet_player")
        {
            gameObject.SetActive(false);
        }
    }
}
