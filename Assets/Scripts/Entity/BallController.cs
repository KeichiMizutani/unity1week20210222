using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : EntityController
{
    ///<summary>
    ///
    ///</summary>
    [SerializeField] VariableJoystick variableJoystick;
    [SerializeField] float speed;
    private Vector3 direction;


    [SerializeField] Text energyText;

    public override void Start()
    {
        entityStatus = new PlayerStatus();
        base.Start();
    }

    public override void Update()
    {
        base.Update();

        float ap = entityStatus.Energy();
        energyText.text = ap.ToString("f2");
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    public override void AddDamage(float damage)
    {
        base.AddDamage(damage);
    }
}
