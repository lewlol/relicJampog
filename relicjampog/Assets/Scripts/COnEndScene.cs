using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COnEndScene : MonoBehaviour
{

    public Text endtime;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        endtime.text = "You took  " + Stopwatch.minutesfinal + ":" + Stopwatch.secondsfinal + "  to reunite them.";
    }


}
