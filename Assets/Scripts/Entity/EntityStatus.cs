using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStatus
{
    private float _hp = 0.0f;
    public float HP
    {
        get
        {
            return _hp;
        }
        protected set
        {
            if(value < 0.0f)
            {
                _hp = 0.0f;
            }
            else
            {
                _hp = value;
            }
        }
    }

    private float _mass = 0.0f;
    public float Mass
    {
        get
        {
            return _mass;
        }
        set
        {
            if(value < 0.0f)
            {
                _mass = 0.0f;
            }
            else
            {
                _mass = value;
            }
        }
    }

    private float _velocity = 0.0f;
    public float Velocity
    {
        get
        {
            return _velocity;
        }
        set
        {
            if (value < 0.0f)
            {
                _velocity = 0.0f;
            }
            else
            {
                _velocity = value;
            }
        }
    }

    public float _maxVelocity = 0.0f;
    public float MaxVelocity
    {
        get
        {
            return _maxVelocity;
        }
        set
        {
            if (value < 0.0f)
            {
                _maxVelocity = 0.0f;
            }
            else
            {
                _maxVelocity = value;
            }
        }
    }

    public EntityStatus(float hp, float mass, float maxVelocity)
    {
        HP = hp;
        Mass = mass;
        MaxVelocity = maxVelocity;
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
