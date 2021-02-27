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
    private float attackBonusRatio = 1.3f;

    [SerializeField] Text energyText;
    [SerializeField] GameObject rotationChecker;
    [SerializeField] ParticleSystem powerParticle;
    private int rotateCount = 0;
    private int powerCount = 0;

    private bool[] rotationCheckerFlags = { false, false, false, false };

    public override void Start()
    {
        entityStatus = new PlayerStatus();
        rotationChecker.transform.parent = null;
        base.Start();
    }

    public override void Update()
    {
        base.Update();

        float ap = entityStatus.Energy();
        energyText.text = (ap * Mathf.Pow(attackBonusRatio, rotateCount)).ToString("f2");

        if (rotateCount <= 10)
        {
            powerCount = rotateCount;
        }
        powerParticle.emissionRate = 10f * powerCount;

        if (variableJoystick.isPointerDown)
        {
            float checkerAngle =rotationChecker.transform.eulerAngles.y;

            if(30f < checkerAngle && checkerAngle < 60f)
            {
                rotationCheckerFlags[0] = true;
            }else if(120f < checkerAngle && checkerAngle < 150f)
            {
                rotationCheckerFlags[1] = true;
            }
            else if(210f < checkerAngle && checkerAngle < 240f)
            {
                rotationCheckerFlags[2] = true;
            }
            else if(300f < checkerAngle && checkerAngle < 330f)
            {
                rotationCheckerFlags[3] = true;
            }

            for(int i = 0; i < rotationCheckerFlags.Length; i++)
            {
                if (!rotationCheckerFlags[i])
                {
                    return;
                }
            }
            OnRotated();
        }
        else
        {
            rotateCount = 0;
        }
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;

        rotationChecker.transform.LookAt(new Vector3(variableJoystick.Horizontal, transform.position.y + 1, variableJoystick.Vertical));

        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    public override void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<IDamagable>() != null)
        {
            other.gameObject.GetComponent<IDamagable>().AddDamage(entityStatus.Energy() * Mathf.Pow(attackBonusRatio, rotateCount));
            rotateCount = 0;
        }
    }

    public override void AddDamage(float damage)
    {
        base.AddDamage(damage);
    }

    private void OnRotated()
    {

        rotateCount++;
        for (int i = 0; i < rotationCheckerFlags.Length; i++)
        {
            rotationCheckerFlags[i] = false;
        }
        //Debug.Log(Mathf.Pow(attackBonusRatio, rotateCount));
    }
}
