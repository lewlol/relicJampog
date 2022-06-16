using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leveluicount : MonoBehaviour
{

    public Text level;
   public string john;

    // Update is called once per frame
    void Update()
    {
        level.text = NextLevelTrigger.levelnum + "/12";
    }
}
