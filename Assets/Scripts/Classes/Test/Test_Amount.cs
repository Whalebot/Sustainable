using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test_Amount : MonoBehaviour
{
    public Image fill;
    public Color currentCol;
    public Color originalCol;
    public Color lightCol;
    public Color darkCol;
    public float lerpTime;
    public float duration;
    public float waitSec;

    public TextMeshProUGUI tMP;


    public float _amountCurrent;
    public float _change;
    public float amountCurrent
    {
        get { return _amountCurrent; }
        set
        {
            if(value > _amountCurrent)
            {
                lerpTime = 0f;
                //currentCol = Color.Lerp(originalCol, lightCol, lerpTime);
                currentCol = Color.Lerp(originalCol, lightCol, 1f);
                StartCoroutine(positiveCoroutine());
            }
            else if (value < _amountCurrent)
            {
                lerpTime = 0f;
                //currentCol = Color.Lerp(originalCol, darkCol, lerpTime);
                currentCol = Color.Lerp(originalCol, darkCol, 1f);

                StartCoroutine(negativeCoroutine());
            }
            _change = _amountCurrent - value;
            _amountCurrent = value;
        }
    }

    public void Start()
    {
        currentCol = originalCol;
    }

    IEnumerator positiveCoroutine()
    {
        Debug.Log("amount increased");
        //currentCol = Color.Lerp(originalCol, lightCol, 0.5f);
        yield return new WaitForSeconds(waitSec);
        lerpTime = 0f;
        //currentCol = Color.Lerp(lightCol, originalCol, lerpTime);
        currentCol = Color.Lerp(lightCol, originalCol, 1f);




    }

    IEnumerator negativeCoroutine()
    {
        Debug.Log("amount decreased");
        //currentCol = Color.Lerp(originalCol, darkCol, 0.5f);
        yield return new WaitForSeconds(waitSec);
        lerpTime = 0f;
        //currentCol = Color.Lerp(darkCol, originalCol, lerpTime);
        currentCol = Color.Lerp(darkCol, originalCol, 1f);


    }


    public void Update()
    {
        fill.color = currentCol;
        tMP.text = amountCurrent.ToString("0.00");
        //lerpTime += Time.deltaTime * duration;
    }

}
