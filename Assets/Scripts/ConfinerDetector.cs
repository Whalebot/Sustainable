using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfinerDetector : MonoBehaviour
{
    public RecenterButtonSlider recenterer;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        recenterer.SlideInButton();
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        recenterer.SlideOutButton();
    }

    //public void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Entered");
    //    recenterer.SlideInButton();
    //}

    //public void OnCollisionExit(Collision collide)
    //{
    //    Debug.Log("Exited");
    //    recenterer.SlideOutButton();
    //}
}
