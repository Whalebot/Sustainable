using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinitabSwitcher : MonoBehaviour
{
    public GameObject[] selectedButtons;
    //public GameObject[] deselectedButtons;
    public GameObject[] backgroundPanels;
    public GameObject[] upBgPanels;

    public bool isFood;
    public Animator minitabHoverer00;
    public Animator minitabHoverer01;
    public Animator minitabHoverer02;
    public Animator minitabHoverer03;
    public Animator minitabHoverer04;

    public Animator iconHoverer00;
    public Animator iconHoverer01;
    public Animator iconHoverer02;
    public Animator iconHoverer03;
    public Animator iconHoverer04;


    public void Start()
    {
        selectedButtons[0].gameObject.SetActive(false);
        backgroundPanels[0].gameObject.SetActive(true);
        upBgPanels[0].gameObject.SetActive(true);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);
        upBgPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);
        upBgPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);
        upBgPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);
        upBgPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel00()
    {
        if (isFood == true)
        {
            minitabHoverer00.SetBool("isHovering", false);
            iconHoverer00.SetBool("isHovering", false);
        }

        selectedButtons[0].gameObject.SetActive(false);
        backgroundPanels[0].gameObject.SetActive(true);
        upBgPanels[0].gameObject.SetActive(true);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);
        upBgPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);
        upBgPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);
        upBgPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);
        upBgPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel01()
    {
        if (isFood == true)
        {
            minitabHoverer01.SetBool("isHovering", false);
            iconHoverer01.SetBool("isHovering", false);

        }

        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);
        upBgPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(false);
        backgroundPanels[1].gameObject.SetActive(true);
        upBgPanels[1].gameObject.SetActive(true);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);
        upBgPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);
        upBgPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);
        upBgPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel02()
    {
        if (isFood == true)
        {
            minitabHoverer02.SetBool("isHovering", false);
            iconHoverer02.SetBool("isHovering", false);

        }

        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);
        upBgPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);
        upBgPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(false);
        backgroundPanels[2].gameObject.SetActive(true);
        upBgPanels[2].gameObject.SetActive(true);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);
        upBgPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);
        upBgPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel03()
    {
        if (isFood == true)
        {
            minitabHoverer03.SetBool("isHovering", false);
            iconHoverer03.SetBool("isHovering", false);

        }

        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);
        upBgPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);
        upBgPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);
        upBgPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(false);
        backgroundPanels[3].gameObject.SetActive(true);
        upBgPanels[3].gameObject.SetActive(true);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);
        upBgPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel04()
    {
        if (isFood == true)
        {
            minitabHoverer04.SetBool("isHovering", false);
            iconHoverer04.SetBool("isHovering", false);

        }

        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);
        upBgPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);
        upBgPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);
        upBgPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);
        upBgPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(false);
        backgroundPanels[4].gameObject.SetActive(true);
        upBgPanels[4].gameObject.SetActive(true);

    }
}
