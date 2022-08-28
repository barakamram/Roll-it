using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swinger : MonoBehaviour
{
    [SerializeField]
    Vector3 _axis;

    [SerializeField]
    float _speed, _maxAngle, _offset;

    float startTime;


    void Start()
    {
        startTime = Time.time;    
    }
    void Update()
    {
        float angle = Mathf.Sin(_offset + 45 + (startTime - Time.time) * _speed);
        angle = Mathf.Lerp(-_maxAngle,_maxAngle,(1+angle)/2f);

        Vector3 newEulerRotation = _axis * angle;        
        transform.rotation = Quaternion.Euler(newEulerRotation);
    }

}
