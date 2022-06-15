using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class connorlevelcount : MonoBehaviour
{
    public Text level;

    private void Update()
    {
        level.text = "Level " + NextLevelTrigger.levelnum.ToString() + " ...";
    }
}




