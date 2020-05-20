using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragRay : MonoBehaviour
{
    public bool isFreeNow;

    public bool m_Drag;
    public Vector3 m_MouseDownPos = new Vector3 (0f,0f,0f);
    public GameObject cameraParent;

    //References used for recentering:
    public Transform cameraParentTransform;
    public RecenterButtonSlider recenterer;

    //How fast the drag is
    //public float dragSpeed = 1f;
    //public Vector3 vectorDragSpeed = new Vector3(1f,1f,1f);

    public void FreeDrag()
    {
        isFreeNow = true;
    }

    public void Update()
    {
        if (isFreeNow == true)
        {
            if (Input.GetMouseButton(0))
            {
                float HitDist;
                Ray MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 GroundNormal = new Vector3(0.0f, 1.0f, 0.0f),
                        GroundPoint = new Vector3(0.0f, 0.0f, 0.0f);
                Plane GroundPlane = new Plane(GroundNormal, GroundPoint);

                if (m_Drag)
                {
                    GroundPlane.Raycast(MouseRay, out HitDist);
                    Vector3 CurClickPos = MouseRay.GetPoint(HitDist);
                    //This next line may affect speed:
                    //CurClickPos = new Vector3((CurClickPos.x * dragSpeed), (CurClickPos.y), (CurClickPos.z * dragSpeed));
                    cameraParent.transform.position += m_MouseDownPos - CurClickPos;

                }
                else //if (Input.GetMouseButtonDown(0))
                {
                    GroundPlane.Raycast(MouseRay, out HitDist);
                    m_MouseDownPos = MouseRay.GetPoint(HitDist);
                    m_Drag = true;
                }
            }
            else
                m_Drag = false;
        }

        

        
    }

    //public void RecenterAppears()
    //{
    //    //Recenter Button commands
    //    if (cameraParentTransform.position.x > -131f)
    //    {
    //        recenterer.SlideInButton();
    //    }
    //}

    //public bool m_Drag;
    //public Vector3 m_MouseDownPos = new Vector3(0f, 0f, 0f);

    //public void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        float HitDist;
    //        Ray MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        Vector3 GroundNormal = new Vector3(0.0f, 1.0f, 0.0f),
    //                GroundPoint = new Vector3(0.0f, 0.0f, 0.0f);
    //        Plane GroundPlane = new Plane(GroundNormal, GroundPoint);

    //        if (m_Drag)
    //        {
    //            GroundPlane.Raycast(MouseRay, out HitDist);
    //            Vector3 CurClickPos = MouseRay.GetPoint(HitDist);
    //            Camera.main.transform.position += m_MouseDownPos - CurClickPos;
    //        }
    //        else //if (Input.GetMouseButtonDown(0))
    //        {
    //            GroundPlane.Raycast(MouseRay, out HitDist);
    //            m_MouseDownPos = MouseRay.GetPoint(HitDist);
    //            m_Drag = true;
    //        }
    //    }
    //    else
    //        m_Drag = false;
    //}

}
