using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragRay : MonoBehaviour
{

    public bool m_Drag;
    public Vector3 m_MouseDownPos = new Vector3 (0f,0f,0f);

    public void Update()
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
                Camera.main.transform.position += m_MouseDownPos - CurClickPos;
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
