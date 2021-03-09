using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : BulletStatus
{
    public Healing(float hp, float mass, float maxVelocity) : base(hp, mass, maxVelocity)
    {
        HP = hp;
        Mass = mass;
        MaxVelocity = maxVelocity;
    }
    public BulletType bulletType = BulletType.HEALING;
}
