using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 弾のEntityとしての属性
/// </summary>
public class BulletController : EntityController
{
    

    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
    }

    public override void AddDamage(float damage)
    {
        base.AddDamage(damage);
    }
}
