using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    Rigidbody2D my_Rigidbody;

    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        my_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            MoveShip();
        }
    }

    private void MoveShip()
    {
        Vector3 shipMovement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        my_Rigidbody.transform.position += shipMovement * moveSpeed * Time.deltaTime;
    }

    private void ShootBullets()
    {

    }
}
