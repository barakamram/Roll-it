using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_LinkedTransform : TransformEffects
{
    [SerializeField]
    Transform _transform;
    public override List<Transform> Apply(List<Transform> transforms)
    {
        transforms.Add(_transform);
        return transforms;
    }
}