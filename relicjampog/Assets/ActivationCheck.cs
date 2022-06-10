using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationCheck : MonoBehaviour
{
    public SpriteRenderer tile;
    public Sprite active;
    public Sprite deActive;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "power")
        {
            Activated();
        }
        if(other.gameObject.tag == "connection" && other.gameObject.GetComponentInParent<BlockActivated>().isActive == true)
        {
            Activated();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "power")
        {
            DeActivated();
        }
        if (other.gameObject.tag == "connection" && other.gameObject.GetComponentInParent<BlockActivated>().isActive == true)
        {
            DeActivated();
        }
    }

    public void Activated()
    {
        tile.sprite = active;
        gameObject.GetComponentInParent<BlockActivated>().isActive = true;
    }
    public void DeActivated()
    {
        tile.sprite = deActive;
        gameObject.GetComponentInParent<BlockActivated>().isActive = false;
    }
}
