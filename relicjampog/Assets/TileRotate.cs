using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRotate : MonoBehaviour
{
    public float lPos;
    public float rPos;
    private void Start()
    {
        lPos = 90;
        rPos = 90;
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
        LeanTween.rotateZ(gameObject, lPos, 0.5f);
        lPos += 90;
        rPos -= 90;
        if (rPos < -270)
        {
            rPos = 0;
        }
        if (lPos > 270)
        {
            lPos = 0;
        }
    }
    public void RotateRight()
    {
        LeanTween.rotateZ(gameObject, rPos, 0.5f);
        rPos -= 90;
        lPos += 90;
        if (rPos < -270)
        {
            rPos = 0;
        }
        if (lPos > 270)
        {
            lPos = 0;
        }
    }
}
