using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MinitabMessageHoverer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator minitabBoxAnimator;

    public void OnPointerEnter(PointerEventData eventData)
    {
        minitabBoxAnimator.SetBool("isHovering", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        minitabBoxAnimator.SetBool("isHovering", false);
    }
}
