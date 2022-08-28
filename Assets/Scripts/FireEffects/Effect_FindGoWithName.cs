using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_FindGoWithName : TransformEffects
{
    [SerializeField]
    string _name;

    public override List<Transform> Apply(List<Transform> transforms)
    {
        GameObject found = GameObject.Find(_name);
        if(found !=null)
            transforms.Add(found.transform);

        return transforms;
    }
}