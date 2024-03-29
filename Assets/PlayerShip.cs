﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShip : MonoBehaviour
{
    Rigidbody2D my_Rigidbody;
    Animator my_animator;
    public float moveSpeed;

    private bool isNeutral = true;


    // Start is called before the first frame update
    void Start()
    {
        my_Rigidbody = GetComponent<Rigidbody2D>();
        my_animator = GetComponent<Animator>();

        my_animator.SetBool("IsNeutral", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            MoveShip();
        }
        else
        {
           
        }

        

        Debug.Log("Horizontal: " + Input.GetAxisRaw("Horizontal"));
       Debug.Log("Vertical: " + Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        AnimateShip();
    }

    private void MoveShip()
    {
        Vector3 shipMovement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        my_Rigidbody.transform.position += shipMovement * moveSpeed * Time.deltaTime;

        
    }

    private void AnimateShip()
    {
        // Turning Left
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            my_animator.SetBool("IsNeutral", false);
            my_animator.SetBool("TurningLeft", true);
        }
        // Turning right
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {

            my_animator.SetBool("IsNeutral", false);
            my_animator.SetBool("TurningRight", true);
        }
        else if (Input.GetAxisRaw("Horizontal") == 0)
        {
            my_animator.SetBool("IsNeutral", true);
            my_animator.SetBool("TurningLeft", false);
            my_animator.SetBool("TurningRight", false);
        }
    }

    private void ShootBullets()
    {

    }

}
