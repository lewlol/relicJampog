using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update


    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Settings()
    {
        //Settings page. Will be on ain menu scene
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}