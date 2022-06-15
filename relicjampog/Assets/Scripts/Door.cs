using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 currentPos;
    public Vector3 newPos;
    public AudioSource sound;

    private void Start()
    {
        currentPos = transform.position;
    }
    public void OpenDoor()
    {
        LeanTween.moveLocal(gameObject, newPos, 0.5f);
        sound.Play();
    }
    public void CloseDoor()
    {
        LeanTween.moveLocal(gameObject, currentPos, 0.5f);
        sound.Play();
    }
}
