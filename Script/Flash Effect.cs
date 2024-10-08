using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class FlashEffect : MonoBehaviour
{
    public SpriteRenderer Spriterenderer;
    public float FlashDuration = 1.1f;
    public Color DefaultColor;
    public Color FlashColor = Color.blue;
    public Tween CurrentTween;

    // Start is called before the first frame update


void Start()
    {
        if (Spriterenderer == null)
        {
            Spriterenderer = GetComponent<SpriteRenderer>();
        }
        DefaultColor = Spriterenderer.color;


    }
    public void StartFlash()
    {
        Flash();
    }
    
    public void Flash()
    {
        Spriterenderer.DOKill();
       
        {
            CurrentTween = Spriterenderer.DOColor(FlashColor, FlashDuration / 2)
             .OnComplete(() =>
             {
                 Spriterenderer.DOColor (DefaultColor, FlashDuration / 2);
                 StopFlash();
             });
        }
      void StopFlash()
        {
            if (CurrentTween != null)
            {
                CurrentTween.Kill();
                Spriterenderer.color = DefaultColor;
                CurrentTween = null;
        }
    }
    }
    
        
    }

    // Update is called once per frame
    