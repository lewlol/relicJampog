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
        StartCoroutine(NextLevelChange());
        cam.transform.position = new Vector3(0, 0, 0);
        cam.transform.position -= new Vector3(30, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player2"))
        {
            StartCoroutine(NextLevelChange());
        }
    }
    IEnumerator NextLevelChange()
    {
        LeanTween.moveLocalY(bar, 0, 0.5f);
        yield return new WaitForSeconds(3f);
        player1.transform.position = p1_spawns[currentLevel].transform.position;
        player2.transform.position = p2_spawns[currentLevel].transform.position;
        cam.transform.position += new Vector3(30, 0, 0);
        currentLevel++;
        LeanTween.moveLocalY(bar, 1080, 0.5f);
    }


}
