using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockActivated : MonoBehaviour
{
    public bool isActive;


    private void Start()
    {
        isActive = false;
    }

    private void Update()
    {
        if(isActive == true)
        {
            gameObject.tag = "active";
        } else
        {
            gameObject.tag = "notActive";
        }
    }
}
