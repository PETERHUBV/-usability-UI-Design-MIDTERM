using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SlideEffect : MonoBehaviour
{
    public SpriteRenderer Spriterenderer;
    public float SlideDuration = 1;
 

    // Start is called before the first frame update
    public void Slide()
    {
        if (Spriterenderer != null)
        {
            Spriterenderer =  GetComponent<SpriteRenderer>();
        }
        Vector3  Position = new Vector3(SlideDuration, 0, 0) + transform.position;
       transform.DOMove(Position, SlideDuration).SetEase(Ease.OutQuad);
    }

}     
    

    // Update is called once per frame
  
