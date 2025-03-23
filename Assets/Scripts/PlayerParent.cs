using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class PlayerParent : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    
    

    public virtual void jump()
    {
        rb.velocity = new Vector2(0, force);
    }
    public virtual void move()
    {
       
    }
}
