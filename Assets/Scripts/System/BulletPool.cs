using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Toolkit;

public class BulletPool : ObjectPool<BulletController>
{
    private GameObject _bullet;

    public BulletPool(GameObject bullet)
    {
        _bullet = bullet;
    }

    protected override BulletController CreateInstance()
    {
        return GameObject.Instantiate(_bullet).GetComponent<BulletController>();
    }
}
