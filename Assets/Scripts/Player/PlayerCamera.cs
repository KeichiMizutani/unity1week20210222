using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    ///<summary>
    ///
    /// </summary>
    [SerializeField] private Transform player;

    ///<summary>
    ///
    /// </summary>
    [SerializeField] private Vector3 offset;

    ///<summary>
    ///
    /// </summary>
    [SerializeField] private float m_DampingRotation = 0.15f;

    ///<summary>
    ///
    /// </summary>
    private Vector3 m_Velocity;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (!player) return;

        Vector3 selfPosition = this.transform.position;
        this.transform.position = Vector3.Lerp(selfPosition, player.position + offset, Mathf.Clamp01(Time.deltaTime / m_DampingRotation));
    }
}
