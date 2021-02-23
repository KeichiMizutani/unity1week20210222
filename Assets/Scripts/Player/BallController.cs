using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    ///<summary>
    ///
    ///</summary>
    [SerializeField] VariableJoystick m_VariableJoystick;
    [SerializeField] float m_Speed;
    private Vector3 m_Direction;
    private Rigidbody m_Rigidbody;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       
    }

    private void FixedUpdate()
    {
        m_Direction = Vector3.forward * m_VariableJoystick.Vertical + Vector3.right * m_VariableJoystick.Horizontal;
        m_Rigidbody.AddForce(m_Direction * m_Speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}
