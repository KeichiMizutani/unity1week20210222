using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : EntityStatus
{
    public PlayerStatus(float hp, float mass, float maxVlocity) : base(hp, mass, maxVlocity)
    {
        HP = hp;
        Mass = mass;
        MaxVelocity = maxVlocity;
    }

    public float speed = 1.0f;
    public float attackBonusRatio = 1.3f;



    public override float Energy()
    {
        return base.Energy();
    }
}
