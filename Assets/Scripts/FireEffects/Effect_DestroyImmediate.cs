using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_DestroyImmediate : TransformEffects
{
    public override List<Transform> Apply(List<Transform> transforms)
    {
        foreach(Transform trs in transforms)
            Destroy(trs.gameObject);

        return transforms;
    }
}