using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timePassed = 0;
    public float timeRemaining;
    // Start is called before the first frame update
    IEnumerator TimerCount(float secondsToCount)
    {
        yield return new WaitForSeconds(secondsToCount);
        timePassed += secondsToCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
