using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpriteTing : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite On;
    public Sprite Off;
    private void OnMouseOver()
    {
        sr.sprite = On;
    }

    private void OnMouseExit()
    {
        sr.sprite = Off;
    }

}
