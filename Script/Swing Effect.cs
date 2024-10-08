using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SwingEffect : MonoBehaviour
{
    public SpriteRenderer Spriterenderer;
    public float SwingDuration = 1;
    public float SwingAngle = 13;

    // Start is called before the first frame update
    public void Swing()
    {
        if (Spriterenderer != null)
        {
            Spriterenderer = GetComponent<SpriteRenderer>();
        }
        transform.DOKill();
        transform.DORotate(new Vector3(0, 0, SwingAngle), SwingDuration).SetEase(Ease.OutQuad).OnComplete(() =>
         transform.DORotate(new Vector3(0, 0, -SwingAngle), SwingDuration).SetEase(Ease.OutQuad).OnComplete(() =>
          transform.DORotate(Vector3.zero, SwingDuration).SetEase(Ease.OutQuad)
          )
        );
    }
        // Update is called once per frame
    }
        
    