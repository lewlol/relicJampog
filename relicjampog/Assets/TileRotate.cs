using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRotate : MonoBehaviour
{
    public float lPos;
    public float rPos;
    private void Start()
    {
        lPos = 0;
        rPos = -180;
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RotateLeft();
            Debug.Log("Left Rotation");
        }
        if (Input.GetMouseButtonDown(1))
        {
            RotateRight();
            Debug.Log("Right Rotation");
        }
    }

    public void RotateLeft()
    {

        lPos = lPos + 90;
        rPos = rPos - 90;
        if (rPos < -270 | rPos > 0)
        {
            rPos = 0;
        }
        if (lPos > 270 | lPos < 0)
        {
            lPos = 0;
        }
        LeanTween.rotateZ(gameObject, lPos, 0.5f);
    }
    public void RotateRight()
    {       
        rPos = rPos - 90;
        lPos = lPos + 90;
        if (rPos < -270 | rPos > 0)
        {
            rPos = 0;
        }
        if (lPos > 270 | lPos < 0)
        {
            lPos = 0;
        }
        LeanTween.rotateZ(gameObject, rPos, 0.5f);
    }
}
