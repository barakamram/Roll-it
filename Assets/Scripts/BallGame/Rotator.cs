using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Rotator : MonoBehaviour
{
    public Vector3 _axis;

    Rigidbody m_rigidbody;

    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.angularVelocity = _axis;
    }

    private void FixedUpdate()
    {
        m_rigidbody.angularVelocity = _axis;
    }

}
