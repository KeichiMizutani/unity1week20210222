using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : EntityStatus
{
    public float speed = 1.0f;
    public float hp = 1000.0f;
    public float attackBonusRatio = 1.3f;

    public override float Energy()
    {
        return base.Energy();
    }
}
