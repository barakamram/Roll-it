using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_SetActive : TransformEffects
{
    [SerializeField]
    bool _active;


    public override List<Transform> Apply(List<Transform> transforms)
    {
        foreach(Transform trs in transforms){
            trs.gameObject.SetActive(_active);
        }

        return transforms;
    }
}