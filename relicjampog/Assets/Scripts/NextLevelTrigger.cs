using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelTrigger : MonoBehaviour
{
    public Transform player1;
    public Transform player2 ;
    public Transform Cameraposition;
    public Camera maincamera;
    public List<Vector3> player1spawnpoints = new List<Vector3>(); 
    public List<Vector3> player2spawnpoints = new List<Vector3>();
    public int Currentlevel = 0;
    public GameObject transition;
    public static float levelnum;
    public Text leveltext;


    // Start is called before the first frame update


    private void Start()
    {
       
       
        Currentlevel = 0;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player2"))
        {
            StartCoroutine(NextLevel());
        }
    }

    IEnumerator NextLevel()
    {
        LeanTween.moveLocalY(transition, 0, 0.5f);
        yield return new WaitForSeconds(0.2f);
        Currentlevel++;
        yield return new WaitForSeconds(0.0001f);
        leveltext.enabled = true;
        maincamera.transform.position = Cameraposition.position + new Vector3(30f, 0, 0);
        player1.position = player1spawnpoints[Currentlevel];
        player2.position = player2spawnpoints[Currentlevel];
        yield return new WaitForSeconds(0.0001f);

        yield return new WaitForSeconds(3f);
        LeanTween.moveLocalY(transition, 1080, 0.5f);



    }


    private void Update()
    {
        levelnum = Currentlevel + 1;
    }




}
