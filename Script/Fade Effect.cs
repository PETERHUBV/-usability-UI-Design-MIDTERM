using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeEffect : MonoBehaviour
{
    public SpriteRenderer Spriterenderer;
    public float FadeDuration = 1.0f;
    public Color DefaultColor;
    // Start is called before the first frame update
    void Start()
    {
        DefaultColor = Spriterenderer.color;


    }
    public void FadeOutAndIn()
    {
        Spriterenderer.DOKill();

        Spriterenderer.DOColor(new Color(DefaultColor.r, DefaultColor.g, DefaultColor.b, 0), FadeDuration).OnComplete(() =>
        {

            Spriterenderer.DOColor(new Color(DefaultColor.r, DefaultColor.g, DefaultColor.b, 1), FadeDuration);
        });
    }
    // Update is called once per frame
}
