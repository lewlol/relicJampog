using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerchange : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player1on;
    public GameObject player2on;
    public bool isplayer1;
    

    private void Awake()
    {
      player1.GetComponent<testmovement>().enabled = true;
        player2.GetComponent<testmovement>().enabled = false;
        isplayer1 = true;
        player1on.SetActive(true);
        player2on.SetActive(false);


    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && (isplayer1 == true) )
        {
            player1.GetComponent<testmovement>().enabled = false;
            player2.GetComponent<testmovement>().enabled = true;
            isplayer1 = false;
            Debug.Log("Switch to 2");
            player1on.SetActive(false);
            player2on.SetActive(true);




        }
        else if (Input.GetKeyDown(KeyCode.Return) && (isplayer1 == false))
        {
            player1.GetComponent<testmovement>().enabled = true;
            player2.GetComponent<testmovement>().enabled = false;
            isplayer1 = true;
            Debug.Log("Switch to 1");
            player1on.SetActive(true);
            player2on.SetActive(false);




        }




    }

    

    



}
