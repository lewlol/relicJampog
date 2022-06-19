using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
  
    public Canvas mainmenu;
    public Canvas Settingscan;
    public GameObject backbutton;

    public AudioSource sounds;

    private void Start()
    {
        backbutton.SetActive(false);
        Settingscan.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Play()
    {
        sounds.Play();
        SceneManager.LoadScene("StorySelect");
    }

    public void Settings()
    {
        sounds.Play();
        mainmenu.enabled = false;
        Settingscan.enabled = true;
        backbutton.SetActive(true);
    }

    public void back()
    {
        sounds.Play();
        mainmenu.enabled = true;
        Settingscan.enabled = false;
        backbutton.SetActive(false);
    }

    
}
