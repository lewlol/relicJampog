using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COnEndScene : MonoBehaviour
{

    public Text endtime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("endsceneswag");
    }

    // Update is called once per frame
    void Update()
    {
        endtime.text = "You took " + Stopwatch.minutesfinal + " Minutes and " + Stopwatch.secondsfinal + "Seconds to reunite them !!";
    }


    IEnumerator endsceneswag()
    {
        yield return new WaitForSeconds(3f);
        endtime.enabled = true; 

    }
}
