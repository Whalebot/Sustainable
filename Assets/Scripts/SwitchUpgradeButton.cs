using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchUpgradeButton : MonoBehaviour
{
    public GameObject shrinkerButt;
    public GameObject unshrinkerButt;
    public bool shrinkerIsOn;

    //public float waitTime;

    public void SwitchButtons()
    {
        //StartCoroutine(SwitchWaitCoroutine());
        shrinkerIsOn = !shrinkerIsOn;

    }

    public void Update()
    {
        if (shrinkerIsOn == true)
        {
            shrinkerButt.gameObject.SetActive(true);
            unshrinkerButt.gameObject.SetActive(false);
        }
        else if (shrinkerIsOn ==false)
        {
            shrinkerButt.gameObject.SetActive(false);
            unshrinkerButt.gameObject.SetActive(true);

        }

    }
    //IEnumerator SwitchWaitCoroutine()
    //{

    //    yield return new WaitForSeconds(waitTime);
    //    shrinkerIsOn = !shrinkerIsOn;

    //}
}
