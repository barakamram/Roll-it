using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_DestroyAfter : TransformEffects
{
    [SerializeField]
    float _time;

    public override List<Transform> Apply(List<Transform> transforms)
    {
        foreach(Transform trs in transforms){
            Destroy(trs.gameObject, _time);
        }

        return transforms;
    }
}