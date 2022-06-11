using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileActivation : MonoBehaviour
{
    public bool isActive = false;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "connection" && collision.GetComponent<TileActivation>().isActive == true)
        {
            isActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "connection" && collision.GetComponent<TileActivation>().isActive == true)
        {
            isActive = false;
        }
    }

    private void Update()
    {
        if(isActive == true)
        {
            Activate();
        } else
        {
            DeActivate();
        }
    }
    void Activate()
    {
        Debug.Log("Block Activated");
    }
    void DeActivate()
    {
        Debug.Log("Block DeActivated");
    }
}
