using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_SpawnAt : TransformEffects
{
    [SerializeField]
    bool _makeParent;

    [SerializeField]
    bool _passCreated, _passOriginal;

    [SerializeField]
    GameObject _prefab;

    public override List<Transform> Apply(List<Transform> transforms)
    {
        List<Transform> returnedTransforms = new List<Transform>();
        GameObject newObject;

        foreach (Transform trs in transforms)
        {
            newObject = Instantiate(_prefab, trs.position, Quaternion.identity);

            if (_makeParent)
                newObject.transform.SetParent(trs);

            if (_passCreated)
                returnedTransforms.Add(newObject.transform);
        }

        if (_passOriginal)
            returnedTransforms.AddRange(transforms);

        return returnedTransforms;
    }
}