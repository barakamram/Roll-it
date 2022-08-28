using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_TransformTimedEffects : TransformEffects
{
    [SerializeField]
    float _scaleBy = 1f;

    [SerializeField]
    float _time = 1f;

    [SerializeField]
    TransformEffects _onFinish;


    public override List<Transform> Apply(List<Transform> transforms)
    {
        StartCoroutine("_ApplyTransforms", transforms);
        return transforms;
    }

    IEnumerator _ApplyTransforms(List<Transform> transforms)
    {

        float elapsedTime = 0;

        if (_time <= 0)
            foreach (Transform trs in transforms)
                trs.localScale = trs.localScale * _scaleBy;


        else
        {
            List<Vector3> startTransforms = new List<Vector3>();
            List<Vector3> endTransforms = new List<Vector3>();

            foreach (Transform trs in transforms)
            {
                startTransforms.Add(trs.localScale);
                endTransforms.Add(trs.localScale * _scaleBy);
            }

            while (elapsedTime < _time)
            {
                int index = -1;
                foreach (Transform trs in transforms)
                {
                    index++;
                    trs.localScale = Vector3.Lerp(startTransforms[index], endTransforms[index], elapsedTime / _time);
                    elapsedTime += Time.deltaTime;
                }

                yield return null;

            }
        }

        if (_onFinish != null) _onFinish.Apply(transforms);

    }
}