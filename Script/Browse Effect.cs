using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using JetBrains.Annotations;


public class BrowseEffect : MonoBehaviour
{
    public SpriteRenderer Spriterenderer;
    public float BrowseDuration = 1;
    public float BrowseHorizontal = 0.1f;

    public Tween currentTween;
    // Start is called before the first frame update
    public void Sprite()
    {
        if (Spriterenderer != null)
        {
            Spriterenderer = GetComponent<SpriteRenderer>();
        }
    }
   
    public void ToggleBrowsing()
    {
        if (currentTween != null && currentTween.IsActive())
        {
            StopBrowsing();
        }
        else
        {
            StartBrowsing();
        }
    }



    public void StartBrowsing()
    {
        Spriterenderer.DOKill();


        transform.DOMoveX(transform.position.x + BrowseHorizontal, BrowseDuration / 2).SetEase(Ease.OutSine).OnComplete(() =>
        {
        transform.DOMoveX(transform.position.x + BrowseHorizontal, BrowseDuration / 2).SetEase(Ease.InSine);

            {
                StopBrowsing();
            }
        });
    
       

    }
    public void StopBrowsing()
    {
        if (currentTween != null)
        {
            currentTween.Kill(); 
            currentTween = null;
        }

    }
}

    // Update is called once per frame
   