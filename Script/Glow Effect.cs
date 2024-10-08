using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GlowEffect : MonoBehaviour
{

    public SpriteRenderer Spriterenderer;
    public Color gloweffect = Color.blue;
    public float GlowDuration= 0.5f;
    public Color DefaultColor;
    // Start is called before the first frame update
    void Start()
    {
        DefaultColor = Spriterenderer.color;
    }

    public void Glow()
    {
        Spriterenderer.DOKill();
        Spriterenderer.DOColor(gloweffect, GlowDuration).OnComplete(() => {

            Spriterenderer.DOColor(DefaultColor, GlowDuration);
        });
    // Update is called once per frame
   

    }
}
