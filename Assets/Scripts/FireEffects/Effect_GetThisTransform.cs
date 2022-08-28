using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_GetThisTransform : TransformEffects
{
    
    public override List<Transform> Apply(List<Transform> transforms)
    {
        transforms.Add(transform);
        return transforms;
    }
}