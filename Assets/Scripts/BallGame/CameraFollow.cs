using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform _target;

    Vector3 m_offset;

    void Start()
    {
        if(_target == null){
            this.enabled = false;
            return;
        }

        m_offset =  transform.position - _target.position;
    }

    void LateUpdate()
    {
        transform.position = m_offset + _target.position;
    }

    public void SetTarget(Transform newTarget){
        _target = newTarget;
    }
}
