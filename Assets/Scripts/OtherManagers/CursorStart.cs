using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CursorStart : MonoBehaviour
{
    // REF FOR RENDER.
    public bool needsRender;

    // REF FOR TYPE OF CURSOR CONTEXT.
    public bool isBusyWithButton;

    public Texture2D cursorGeneral;
    public Texture2D cursorDrag;
    public Texture2D cursorClickable;
    public Texture2D cursorClickdown;
    public Texture2D cursorInfo;
    public Texture2D cursorBlocked;
    public Texture2D cursorIndustrial;
    public Texture2D cursorIndustrialdown;


    // Start is called before the first frame update
    void Start()
    {
        if (needsRender == true)
        {
            Cursor.SetCursor(cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    public void Update()
    {
        if (isBusyWithButton == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (needsRender == true)
                {
                    Cursor.SetCursor(cursorDrag, Vector2.zero, CursorMode.ForceSoftware);
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                if (needsRender == true)
                {
                    Cursor.SetCursor(cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);
                }
                
            }
        }
    }

}
