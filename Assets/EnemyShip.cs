using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public GameObject bullet;

    public float score;
    private float shootTimer;
    private bool isEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        isEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled == true)
        {
            MoveShip();
        }
    }

    private void ShootBullet()
    {

    }

    private void MoveShip()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.down * 100);
    }
}
