using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraManager : MonoBehaviour
{
    public bool mouseButtonHeld;
    public CinemachineVirtualCamera overviewCam;
    public Vector3 mouseDelta;
    Vector3 relativeMovement;
    public float cameraSpeedX = 1;
    public float cameraSpeedY = 1;

    public float zoomSpeed = 10;
    public float camSize = 120F;
    public float minZoom, maxZoom;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnMouseDown()
    {

    }

    private void OnMouseUp()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { mouseButtonHeld = !CursorScript.Instance.foundInteractable; }
        if (Input.GetMouseButtonUp(0)) mouseButtonHeld = false;

        if (mouseButtonHeld)
        {
            mouseDelta = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
            Vector3 tempForward = overviewCam.transform.forward;
            tempForward.y = 0;
            tempForward = tempForward.normalized;
            relativeMovement = overviewCam.transform.right * mouseDelta.x * -cameraSpeedX + tempForward * mouseDelta.y * -cameraSpeedY;
            overviewCam.transform.position = overviewCam.transform.position + relativeMovement;
        }

        camSize += -Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        camSize = Mathf.Clamp(camSize, minZoom, maxZoom);
        overviewCam.m_Lens.OrthographicSize = camSize;

    }
}
