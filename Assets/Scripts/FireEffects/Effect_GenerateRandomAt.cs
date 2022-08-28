using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_GenerateRandomAt : TransformEffects
{
    [SerializeField]
    Transform _center;
    [SerializeField]
    Vector3 _jitter;
    [SerializeField]
    GameObject _prefab;

    [SerializeField]
    int _howMany = 1;

    private void OnDrawGizmosSelected()
    {
        if (_center != null)
        {
            Gizmos.DrawWireCube(_center.transform.position, _jitter);
        }
    }

    public override List<Transform> Apply(List<Transform> transforms)
    {
        for(int index = 0; index < _howMany; index++){
            Vector3 randomPos = new Vector3(Random.Range(-_jitter.x,_jitter.x)/2,Random.Range(-_jitter.y,_jitter.y)/2,Random.Range(-_jitter.z,_jitter.z)/2);
            randomPos += _center.transform.position;
            transforms.Add(Instantiate(_prefab,randomPos,_prefab.transform.rotation).transform);
        }

        return transforms;
    }
}