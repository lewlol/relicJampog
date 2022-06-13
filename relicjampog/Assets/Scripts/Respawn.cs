using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform groundCheck;
    public Vector3 respawnPos;

    [SerializeField] public LayerMask groundLayer;



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Physics2D.OverlapCircle(groundCheck.position, 0.25f, groundLayer))
        {
            respawnPos = gameObject.transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ResBar")
        {
            gameObject.transform.position = respawnPos;
        }
    }
}
