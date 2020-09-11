using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchUpgradeButton : MonoBehaviour
{
    public GameObject shrinkerButt;
    public GameObject unshrinkerButt;
    public bool shrinkerIsOn;

    public GameObject xNormalButt;
    public GameObject xUnshrinkerButt;
    //public bool xShrinkerIsOn;


    public void SwitchButtons()
    {
        //StartCoroutine(SwitchWaitCoroutine());
        shrinkerIsOn = !shrinkerIsOn;

        if (shrinkerIsOn == true)
        {
            shrinkerButt.gameObject.SetActive(true);
            xNormalButt.gameObject.SetActive(true);
            unshrinkerButt.gameObject.SetActive(false);
            xUnshrinkerButt.gameObject.SetActive(false);
        }
        else if (shrinkerIsOn == false)
        {
            shrinkerButt.gameObject.SetActive(false);
            xNormalButt.gameObject.SetActive(false);
            unshrinkerButt.gameObject.SetActive(true);
            xUnshrinkerButt.gameObject.SetActive(true);

        }

    }

    //public void SwitchTradeOffCloseButtons()
    //{
    //    shrinkerIsOn = !shrinkerIsOn;


    //}

    //public void Update()
    //{
    //    if (shrinkerIsOn == true)
    //    {
    //        shrinkerButt.gameObject.SetActive(true);
    //        unshrinkerButt.gameObject.SetActive(false);
    //    }
    //    else if (shrinkerIsOn ==false)
    //    {
    //        shrinkerButt.gameObject.SetActive(false);
    //        unshrinkerButt.gameObject.SetActive(true);

    //    }

    //}
   
}
