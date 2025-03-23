using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerB : PlayerParent
{
    public float speed;
    float MovementX;
    float MovementY;
    
    
    
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        move();
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            jump();
        }
    }
    
    

    public override void jump()
    {
        base.jump();
    }

    public override void move()
    {
        
        base.move();
        MovementX = Input.GetAxis("Horizontal1");
        MovementY = Input.GetAxis("Vertical1");
        
        transform.Translate(MovementX * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, MovementY * speed * Time.deltaTime, 0);
    }
}
