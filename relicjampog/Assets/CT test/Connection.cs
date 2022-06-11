using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour


{
    public SpriteRenderer tile;
    public Sprite active;
    public Sprite deActive;
    public GameObject currentting;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "power")
        {
            Activated();
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        DeActivated();
        
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
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
