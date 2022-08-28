using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_FlushTransforms : TransformEffects
{

    public override List<Transform> Apply(List<Transform> transforms)
    {
        transforms.Clear();

        return transforms;
    }
}