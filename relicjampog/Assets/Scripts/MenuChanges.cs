using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChanges : MonoBehaviour
{
    public void Play()
    {
        //SceneManager.LoadScene("); //add level selector or name of scene like below
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
