using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotator : MonoBehaviour
{
    public Vector3 _axis;


    private void Update()
    {
        transform.Rotate(_axis*Time.deltaTime);
    }

}
