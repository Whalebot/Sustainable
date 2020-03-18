using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiFollowMouse : MonoBehaviour
{
    public RectTransform movingDiv;
    public Vector3 offset;
    public RectTransform zBasis;
    public Camera cam;

    public float zValue = 0f;

    public void Update()
    {
        MoveUi();
    }

    public void MoveUi()
    {
        Vector3 pos = Input.mousePosition + offset;
        //pos.z = zBasis.position.z;
        pos.z = zValue;

        movingDiv.position = cam.ScreenToWorldPoint(pos);
    }

}
