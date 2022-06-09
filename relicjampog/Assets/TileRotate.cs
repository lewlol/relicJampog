using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRotate : MonoBehaviour
{
    public float currentPos;
    public float finalpos;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeanTween.rotateZ(gameObject, finalpos, 0.5f);
        }
    }
}
