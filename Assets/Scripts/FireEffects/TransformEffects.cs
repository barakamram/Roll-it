using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class TransformEffects : MonoBehaviour{

    public abstract List<Transform> Apply(List<Transform> transforms);

    public List<Transform> Apply(){
        List<Transform> trsList = new List<Transform>();
        Apply(trsList);

        return trsList;
    }

    public List<Transform> Apply(Transform trs){
        List<Transform> trsList = new List<Transform>();
        trsList.Add(trs);
        Apply(trsList);

        return trsList;
    }


    private void Update(){/*To make script enabled and run coroutines*/}
}