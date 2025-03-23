using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : PlayerParent
{
    public float speed;
    float MovementX;
    float MovementY;

    private void Update()
    {
        move();
        if (Input.GetKeyDown(KeyCode.Space))
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
        MovementX = Input.GetAxis("Horizontal");
        MovementY = Input.GetAxis("Vertical");
        
        transform.Translate(MovementX * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, MovementY * speed * Time.deltaTime, 0);
    }
}
