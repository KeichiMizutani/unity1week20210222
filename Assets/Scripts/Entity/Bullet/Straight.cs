using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ストレート弾のステータス
/// </summary>
public class Straight : BulletStatus
{
    public Straight(float hp, float mass, float maxVelocity) : base(hp, mass, maxVelocity)
    {
        HP = hp;
        Mass = mass;
        MaxVelocity = maxVelocity;
    }

    public BulletType bulletType = BulletType.STRAIGHT;
}
