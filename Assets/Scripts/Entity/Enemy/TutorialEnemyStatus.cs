using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnemyStatus : EntityStatus
{
    public TutorialEnemyStatus(float hp, float mass, float maxVlocity) : base(hp, mass, maxVlocity)
    {
        HP = hp;
        Mass = mass;
        MaxVelocity = maxVlocity;
    }

    public override float Energy()
    {
        return base.Energy();
    }
}
