using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : BulletStatus
{
    public Homing(float hp, float mass, float maxVelocity) : base(hp, mass, maxVelocity)
    {
        HP = hp;
        Mass = mass;
        MaxVelocity = maxVelocity;
    }

    public BulletType bulletType = BulletType.HOMING;
}
