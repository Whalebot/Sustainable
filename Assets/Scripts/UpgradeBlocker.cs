using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBlocker : MonoBehaviour
{
    //THIS SCRIPT GOES IN THE BUTTON THAT ONCE CLICKED WILL BLOCK ANOTHER UPGRADE.
    public GameObject offButtonBlock;


    public void Start()
    {
        offButtonBlock.gameObject.SetActive(false);

    }

    public void BlockUpgrade()
    {
        offButtonBlock.gameObject.SetActive(true);
    }
}
