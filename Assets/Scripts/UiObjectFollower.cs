using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiObjectFollower : MonoBehaviour
{
    public RectTransform movingDiv;
    public Vector3 offset;
    public RectTransform zBasis;
    public Camera cam;

    public Transform objectToFollow;

    public float zValue = 0f;

    public void Update()
    {
        MoveObjectUi();
    }

    public void MoveObjectUi()
    {
        Vector3 pos = objectToFollow.position + offset;
        //pos.z = zBasis.position.z;
        pos.z = zValue;

        movingDiv.position = cam.ScreenToWorldPoint(pos);
    }
}
