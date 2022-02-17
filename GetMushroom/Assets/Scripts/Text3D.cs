using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text3D : MonoBehaviour
{
    [HideInInspector]
    public GameObject Object3D;//3DÎïÌå
    [HideInInspector]
    public GameObject UI3D;
    [HideInInspector]
    public Vector3 Offset;
    [HideInInspector]
    public bool UISelected = true;
    [HideInInspector]
    public bool UIShowed = true;

    // Update is called once per frame
    void Update()
    {
        if (Object3D != null && UI3D != null)
        {
            Vector2 screenPos = Camera.main.WorldToScreenPoint(Object3D.transform.position + Offset);
            UI3D.GetComponent<Text>().rectTransform.position = screenPos;

            if (!UIShowed)
            {
                UI3D.SetActive(false);
            }
            else
            {
                if (UISelected)
                    UI3D.SetActive(true);
                else
                    UI3D.SetActive(false);
            }

        }

    }

    private void OnBecameInvisible()
    {
        UIShowed = false;
    }
    private void OnBecameVisible()
    {
        UIShowed = true;
    }
}
