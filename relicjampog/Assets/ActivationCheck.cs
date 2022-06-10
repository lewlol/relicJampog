using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationCheck : MonoBehaviour
{
    public SpriteRenderer tile;
    public Sprite active;
    public Sprite deActive;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "connection" && collision.gameObject.GetComponentInParent<BlockActivated>().isActive == true)
        {
            tile.sprite = active;
            Debug.Log("Connected");
            gameObject.GetComponentInParent<BlockActivated>().isActive = true;
        }

        if(collision.gameObject.tag == "power")
        {
            gameObject.GetComponentInParent<BlockActivated>().isActive = true;
            tile.sprite = active;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "connection" && collision.gameObject.GetComponentInParent<BlockActivated>().isActive == true)
        {
            tile.sprite = deActive;
            Debug.Log("Disconnected");
            gameObject.GetComponentInParent<BlockActivated>().isActive = false;
        }
        if (collision.gameObject.tag == "power")
        {
            gameObject.GetComponentInParent<BlockActivated>().isActive = false;
            tile.sprite = deActive;
        }
    }
}
