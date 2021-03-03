using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾ごとにアタッチするStatusは変わります。（BuletController側で決めてもらう。）
/// </summary>
public class BulletStatus : EntityStatus
{
    public enum BulletType
    {
        STRAIGHT,
        HOMING,
        BOUND,
        HEALING,
    }

    public override float Energy()
    {
        return base.Energy();   
    }
}
