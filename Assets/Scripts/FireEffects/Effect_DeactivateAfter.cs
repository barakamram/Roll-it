using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_DeactivateAfter : TransformEffects
{
    [SerializeField]
    float _time;

    public override List<Transform> Apply(List<Transform> transforms)
    {
        foreach(Transform trs in transforms){
            StartCoroutine(DeactivateCoroutine(trs));
        }

        return transforms;
    }

    IEnumerator DeactivateCoroutine(Transform trs){
        yield return new WaitForSeconds(_time);
        trs.gameObject.SetActive(false);
    }
}

