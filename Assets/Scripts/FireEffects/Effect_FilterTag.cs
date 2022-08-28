using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_FilterTag : TransformEffects
{
    [SerializeField]
    string _filterTag;

    public override List<Transform> Apply(List<Transform> transforms)
    {
        List<Transform> returnedTransforms = new List<Transform>();
        foreach (Transform trs in transforms){
            if(trs.gameObject.tag == _filterTag)
                returnedTransforms.Add(trs);
        }

        return returnedTransforms;
    }
}