using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideTouchPoint : MonoBehaviour {



    public Transform cursor;
    public Transform surface;

	// Update is called once per frame
	void Update () 
    {
        HideAllTouchPoint();
    }

    private void HideAllTouchPoint()
    {
        for (int i = 0; i < cursor.childCount; i++)
        {
            
            if (cursor.GetChild(i).childCount > 0)
                cursor.GetChild(i).GetChild(0).GetComponent<RawImage>().enabled = false;
        }

        for (int i = 0; i < surface.childCount; i++)
        {
            if (surface.GetChild(i).name.Contains("cursor"))
            {
                surface.GetChild(i).GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

}
