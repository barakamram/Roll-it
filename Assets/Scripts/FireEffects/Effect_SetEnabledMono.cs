using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_SetEnabledMono : TransformEffects
{

    [SerializeField]
    List<MonoBehaviour> _scripts;

    [SerializeField]
    bool _active;


    public override List<Transform> Apply(List<Transform> transforms)
    {
        foreach(MonoBehaviour script in _scripts){
            script.enabled = _active;
        }

        return transforms;
    }
}