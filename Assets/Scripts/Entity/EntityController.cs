using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamagable
{
    void AddDamage(float damage);
}


public class EntityController : MonoBehaviour, IDamagable
{
    protected Rigidbody rb;
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
        entityStatus.Mass = rb.mass;
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
