using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lewNextLevelScript : MonoBehaviour
{
    public GameObject[] p1_spawns;
    public GameObject[] p2_spawns;

    public GameObject player1;
    public GameObject player2;

    int currentLevel = 0;

    public GameObject cam;

    public GameObject bar;


    private void Start()
    {
        bar.SetActive(true);
        StartCoroutine(NextLevelChange());
        cam.transform.position = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player2"))
        {
            StartCoroutine(NextLevelChange());
        }
    }
    IEnumerator NextLevelChange()
    {
        Debug.Log("NextLevel");
        Freezing();
        LeanTween.moveLocalY(bar, 0, 0.5f);
        yield return new WaitForSeconds(3f);
        player1.transform.position = p1_spawns[currentLevel].transform.position;
        player2.transform.position = p2_spawns[currentLevel].transform.position;
        UnFreezing();
        cam.transform.position += new Vector3(30, 0, 0);  
        currentLevel++;
        LeanTween.moveLocalY(bar, 1080, 0.5f);
    }

    void Freezing()
    {
        player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }
    void UnFreezing()
    {
        player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

        player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    }

}
