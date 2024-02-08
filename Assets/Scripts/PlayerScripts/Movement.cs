using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Movement
    //starting variables
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    
    public float lastHorizontalVector;
    
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 moveDir;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManagement();
    }

    private void FixedUpdate()
    {
        move();
    }

    public void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2 (moveX, moveY).normalized;

        if (moveDir.x != 0) 
        {
            lastHorizontalVector = moveDir.x;
        }
        if (moveDir.y != 0) 
        {
            lastVerticalVector = moveDir.y;
        }
    }

    public void move() 
    {
        rb.velocity = new Vector2 (moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
