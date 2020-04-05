using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatAnimation : MonoBehaviour
{
    public bool boatIsSailing;
    public bool hasBroken;
    public Transform[] nextPosition;
    public Vector3 nextPositionV3;
    public Transform stopPosition;
    public int turn;
    public GameObject boat;
    public Transform boatTrans;
    public float speed;
    public float delay;
    public AnimationCurve rotEase;
    public AnimationCurve movEase;
    public AnimationCurve sEase;
    public AnimationCurve easeIn;
    public AnimationCurve easeOut;
    public AnimationCurve linearEase;

    public void Start()
    {
        turn = 1;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            boatIsSailing = true;
            Sail();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            boatIsSailing = false;
            //turn--;
        }

        //if (boatIsSailing == true)
        //{
        //    Sail();
        //}

    }

    public void Sail()
    {

        StartCoroutine(SailCoroutine());

    }

    public void Stop()
    {

    }

    IEnumerator SailCoroutine()
    {
        //turn++;

        while (boatIsSailing == true)
        {
            //turn++;

            nextPositionV3 = new Vector3(nextPosition[turn].position.x, nextPosition[turn].position.y, nextPosition[turn].position.z);
            if (boatIsSailing == false)
            {
                LeanTween.move(boat, nextPositionV3, speed).setEase(easeOut);
                LeanTween.rotateY(boat, nextPosition[turn].eulerAngles.y, speed).setEase(easeOut);

                hasBroken = true;
                yield break;
            }

            else if (boatIsSailing == true)
            {
                if (hasBroken == true)
                {
                    hasBroken = false;
                    LeanTween.move(boat, nextPositionV3, speed).setEase(easeIn);
                    LeanTween.rotateY(boat, nextPosition[turn].eulerAngles.y, speed).setEase(easeIn);
                }

                else if (turn == 1 || turn == 7 || turn == 14)
                {
                    LeanTween.move(boat, nextPositionV3, speed).setEase(easeIn);
                    LeanTween.rotateY(boat, nextPosition[turn].eulerAngles.y, speed).setEase(easeIn);
                }
                else if (turn == 5 || turn == 12 || turn == 19)
                {
                    LeanTween.move(boat, nextPositionV3, speed).setEase(easeOut);
                    LeanTween.rotateY(boat, nextPosition[turn].eulerAngles.y, speed).setEase(easeOut);
                }
                else
                {
                    LeanTween.move(boat, nextPositionV3, speed).setEase(linearEase);
                    LeanTween.rotateY(boat, nextPosition[turn].eulerAngles.y, speed).setEase(linearEase);
                }



                yield return new WaitForSeconds(speed);

                turn++;

                if (turn == nextPosition.Length)
                {
                    turn = 0;
                }
            }

            
        }

        //for (int i = 0; i < nextPosition.Length; i++)
        //{
        //    turn++;
        //    nextPositionV3 = new Vector3(nextPosition[turn].position.x, nextPosition[turn].position.y, nextPosition[turn].position.z);
        //    LeanTween.moveLocal(boat, nextPositionV3, speed).setEase(ease);
        //    LeanTween.rotate(boat, nextPositionV3, speed).setEase(ease);

        //    yield return new WaitForSeconds(speed);

        //    if (turn == nextPosition.Length)
        //    {
        //        turn = -1;
        //    }
        //}





    }

}
