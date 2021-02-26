using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStatus
{
    private float hp = 0.0f;
    public float HP
    {
        get
        {
            return hp;
        }
        protected set
        {
            if(value < 0.0f)
            {
                hp = 0.0f;
            }
            else
            {
                hp = value;
            }
        }
    }

    private float mass = 0.0f;
    public float Mass
    {
        get
        {
            return mass;
        }
        set
        {
            if(value < 0.0f)
            {
                mass = 0.0f;
            }
            else
            {
                mass = value;
            }
        }
    }

    private float velocity = 0.0f;
    public float Velocity
    {
        get
        {
            return velocity;
        }
        set
        {
            if (value < 0.0f)
            {
                velocity = 0.0f;
            }
            else
            {
                velocity = value;
            }
        }
    }

    public virtual float Energy()
    {
        return 0.5f * Mass * Mathf.Pow(Velocity, 2.0f);
    }




    public virtual void Start()
    {
        
    }

    public virtual void Update()
    {
        
    }

}
