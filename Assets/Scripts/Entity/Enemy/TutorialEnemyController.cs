using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnemyController : EntityController
{
    public override void Start()
    {
        entityStatus = new TutorialEnemyStatus();
        base.Start();
    }

    public override void Update()
    {
        base.Update();
    }

    public override void AddDamage(float damage)
    {
        base.AddDamage(damage);
        Debug.Log(damage.ToString("f2") + "のダメージを与えた！");
    }
}
