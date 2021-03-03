using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamagable
{
    void AddDamage(float damage);
}


public class EntityController : MonoBehaviour, IDamagable
{
    public Rigidbody rb;
    public EntityStatus entityStatus;


    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void Update()
    {
        
    }

    public virtual void FixedUpdate()
    {
        rb.mass = entityStatus.Mass;
        if(rb.velocity.magnitude >= entityStatus.MaxVelocity)
        {
            rb.velocity = rb.velocity.normalized * entityStatus.MaxVelocity;
        }
        entityStatus.Velocity = rb.velocity.magnitude;
    }

    public virtual void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.GetComponent<IDamagable>() != null)
        {
            other.gameObject.GetComponent<IDamagable>().AddDamage(entityStatus.Energy());
        }
    }

    public virtual void AddDamage(float damage){

    }

    
}
