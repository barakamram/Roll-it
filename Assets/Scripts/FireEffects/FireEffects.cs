using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffects : TransformEffects
{
    [SerializeField]
    List<TransformEffects> _effects;

    [SerializeField]
    bool _onStart,_repeat,_onTrigger;

    [SerializeField]
    float _repeatInterval;


    
    // Start is called before the first frame update
    void Start()
    {
        if(_onStart) FireAll();

        if(_repeat) StartCoroutine("FireAll_crt");
    }

    private void OnTriggerEnter(Collider other) {

        if(!_onTrigger) return;

        List<Transform> transforms = new List<Transform>();
        transforms.Add(other.transform);

        FireAll(transforms);
        
    }

    public override List<Transform> Apply(List<Transform> transforms){

        List<Transform> clone = new List<Transform>();
        foreach(Transform trs in transforms)
            clone.Add(trs);


        FireAll(clone);

        return transforms;
    }

    IEnumerator FireAll_crt(){
        
        while(true){
            yield return new WaitForSeconds(_repeatInterval);
            FireAll();
        }

    }

    public List<Transform> FireAll(){
        
        List<Transform> transforms = new List<Transform>();
        return _FireAll(transforms);

    }

    public List<Transform> FireAll(Transform transform){
        
        List<Transform> transforms = new List<Transform>();
        transforms.Add(transform);
        return _FireAll(transforms);

    }

    public List<Transform> FireAll(List<Transform> transforms){
        
        return _FireAll(transforms);

    }

    public IEnumerator FireAll_Coroutine(){
        
        List<Transform> transforms = new List<Transform>();
        _FireAll(transforms);

        yield return null;
    }

    public IEnumerator FireAll_Coroutine(List<Transform> transforms){
        
        _FireAll(transforms);
        yield return null;
    }


    List<Transform> _FireAll(List<Transform> transforms){

        foreach (TransformEffects effect in _effects)
                transforms = effect.Apply(transforms);

        return transforms;

    }


}
