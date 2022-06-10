using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbBlock : MonoBehaviour
{
    public Animator powerAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "connection" && collision.gameObject.GetComponent<BlockActivated>().isActive == true)
        {
            powerAnim.SetBool("bulbPowered", true);
        }
    }
}
