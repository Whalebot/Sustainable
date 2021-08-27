using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CursorScript : MonoBehaviour
{
    public Vector3 offset;
    Image img;
    RectTransform rect;
    public Sprite cursorGeneral;
    public Sprite cursorDrag;
    public Sprite cursorClickable;
    public Sprite cursorClickdown;
    public Sprite cursorInfo;
    public Sprite cursorBlocked;
    public Sprite cursorIndustrial;
    public Sprite cursorIndustrialdown;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        img = GetComponent<Image>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rect.position = Input.mousePosition + offset * Screen.width / 1080;
        if (Input.GetMouseButton(0))
            img.sprite = cursorClickdown;
        else
            img.sprite = cursorGeneral;
    }
}
