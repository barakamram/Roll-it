using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Effect_TextureAlpha : TransformEffects
{
    [SerializeField]
    float _changeTo = 1f;

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

        List<SpriteRenderer> sprites = new List<SpriteRenderer>();
        foreach (Transform trs in transforms)
            sprites.Add(trs.GetComponent<SpriteRenderer>());

        if (_time <= 0)

            foreach (SpriteRenderer sprite in sprites){
                Color spriteColor = sprite.color;
                spriteColor.a = _changeTo;
                sprite.color = spriteColor;
            }


        else
        {
            List<Color> startColors = new List<Color>();
            List<Color> endColors = new List<Color>();

            foreach (Transform trs in transforms)
            {
                Color spriteColor = trs.GetComponent<SpriteRenderer>().color;
                startColors.Add(spriteColor);
                spriteColor.a = _changeTo;
                endColors.Add(spriteColor);
            }

            while (elapsedTime < _time)
            {
                int index = -1;
                foreach (SpriteRenderer sprite in sprites)
                {
                    index++;
                    sprite.color = Color.Lerp(startColors[index], endColors[index], elapsedTime / _time);
                    elapsedTime += Time.deltaTime;
                }

                yield return null;

            }
        }

        if (_onFinish != null) _onFinish.Apply(transforms);

    }
}