using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
    public Transform player1;
    public Transform player2 ;
    public Transform Cameraposition;
    public Camera maincamera;
    public List<Vector3> player1spawnpoints = new List<Vector3>(); 
    public List<Vector3> player2spawnpoints = new List<Vector3>();
    public static int Currentlevel = 0;
    public GameObject transition;
    public static float levelnum;
    public static string levelnum2;
    public Text leveltext;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Time;
    


    // Start is called before the first frame update


    private void Start()
    {
       
       
        Currentlevel = 7;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player2"))
        {
            StartCoroutine(NextLevel());
        }
    }

    private void FixedUpdate()
    {
        if(Currentlevel == 8)
        {
            Time.SendMessage("finish");
            SceneManager.LoadScene(5);
        }
    }

    IEnumerator NextLevel()
    {
       


        Player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        Player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

        LeanTween.moveLocalY(transition, 0, 0.5f);
        yield return new WaitForSeconds(0.2f);
        Currentlevel++;
        yield return new WaitForSeconds(0.7f);
        leveltext.enabled = true;
        maincamera.transform.position = Cameraposition.position + new Vector3(30f, 0, 0);
        player1.position = player1spawnpoints[Currentlevel];
        player2.position = player2spawnpoints[Currentlevel];
        yield return new WaitForSeconds(0.0001f);
        Player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        Player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        Player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        Player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;


        yield return new WaitForSeconds(3f);
        leveltext.enabled = false;
        LeanTween.moveLocalY(transition, 1080, 0.5f);



    }


    private void Update()
    {
        levelnum = Currentlevel + 1;

        levelnum2 = Currentlevel.ToString();
    }




}
