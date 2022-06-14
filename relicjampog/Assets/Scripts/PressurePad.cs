using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    [SerializeField] SpriteRenderer PressureP;
    public Sprite off;
    public Sprite on;
    public GameObject activator;

    public SoundManager sMan;
    public AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2")
        {
            PressureP.sprite = on;
            sound.clip = sMan.pressurePadOn;
            sound.Play();
            activator.GetComponent<Door>().SendMessage("OpenDoor");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2")
        {
            PressureP.sprite = off;
            sound.clip = sMan.pressurePadOff;
            sound.Play();
            activator.GetComponent<Door>().SendMessage("CloseDoor");
        }
    }
}
