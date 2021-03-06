using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform groundCheck;
    public Vector3 respawnPos;

    public SpriteRenderer sprite;

    [SerializeField] public LayerMask groundLayer;
    public SoundManager sMan;
    public AudioSource sound;



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
            StartCoroutine(Blinking());
            sound.clip = sMan.respawn;
            sound.Play();
        }
    }
    public void Blink()
    {
        var fade = sprite.color;
        fade.a = 0f;
        sprite.color = fade;
    }
    public void nonBlink()
    {
        var nonfade = sprite.color;
        nonfade.a = 100f;
        sprite.color = nonfade;
    }
    IEnumerator Blinking()
    {
        nonBlink();
        yield return new WaitForSeconds(0.3f);
        Blink();
        yield return new WaitForSeconds(0.3f);

        nonBlink();
        yield return new WaitForSeconds(0.3f);
        Blink();
        yield return new WaitForSeconds(0.3f);

        nonBlink();
        yield return new WaitForSeconds(0.3f);
        Blink();
        yield return new WaitForSeconds(0.3f);
        nonBlink();
    }
}
