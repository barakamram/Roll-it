using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[System.Serializable]
public class Effect_SetMono : TransformEffects
{
    [SerializeReference]
    MonoBehaviour _script;
    [SerializeReference]
    bool _setEnabled;


    public override List<Transform> Apply(List<Transform> transforms)
    {
        foreach(Transform trs in transforms){
            MonoBehaviour newMono = GameTools.Reflection.CopyComponentGeneric<MonoBehaviour>(_script,trs.gameObject);
            newMono.enabled = _setEnabled;
        }

        return transforms;
    }


}