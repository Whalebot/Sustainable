using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CursorScript : MonoBehaviour
{
    public static CursorScript Instance { get; private set; }
    public Vector3 offset;
    Image img;
    RectTransform rect;

    public bool foundInteractable;
    public Sprite cursorGeneral;
    public Sprite cursorDrag;
    public Sprite cursorClickable;
    public Sprite cursorClickdown;
    public Sprite cursorInfo;
    public Sprite cursorBlocked;
    public Sprite cursorIndustrial;
    public Sprite cursorIndustrialdown;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        img = GetComponent<Image>();
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rect.position = Input.mousePosition + offset * Screen.width / 1080;
        if (!foundInteractable)
        {
            if (Input.GetMouseButton(0))
                img.sprite = cursorClickdown;
            else
                img.sprite = cursorGeneral;
        }
    }

    public void Hover() {
        foundInteractable = true;
        img.sprite = cursorClickable;
    }

    public void BlockCursor()
    {

        img.sprite = cursorBlocked;
    }

    public void ResetCursor()
    {
        foundInteractable = false;
        img.sprite = cursorGeneral;
    }
}
