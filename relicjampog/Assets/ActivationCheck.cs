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
        if(collision.gameObject.tag == "connection")
        {
            tile.sprite = active;
            Debug.Log("Connected");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "connection")
        {
            tile.sprite = deActive;
            Debug.Log("Disconnected");
        }
    }
}
