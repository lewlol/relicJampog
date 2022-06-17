using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class concomp : MonoBehaviour
{
    //Fade In
    //Text 1 Fade In
    //Text 2 Fade In
    //Fade Out

    public Animator fade;
    public GameObject reunited;
    public GameObject time;

    private void Start()
    {
        StartCoroutine(FinalScene());
    }
    IEnumerator FinalScene()
    {
        yield return new WaitForSeconds(1f);
        fade.SetBool("fadein", true);
        yield return new WaitForSeconds(3f);
        reunited.SetActive(true);
        yield return new WaitForSeconds(3.2f);
        time.SetActive(true);
        yield return new WaitForSeconds(5f);
        fade.SetBool("fadeout", true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Mainmenu");
    }
}
