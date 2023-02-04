using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerUi;
    public Vector2Int timePassed = new Vector2Int(0, 0);
    public float timeRemaining;
    // Start is called before the first frame update
    IEnumerator TimerCount()
    {
        yield return new WaitForSeconds(1f);
        timePassed.y++;
        if(timePassed.y % 60 == 0) { timePassed.x++; }
        timerUi.text = timePassed.x.ToString() + ":"+timePassed.y.ToString();
        StartCoroutine(TimerCount());
    }
    public void StartCount()
    {
        StartCoroutine(TimerCount());
    }
    // Update is called once per frame
    void Awake()
    {
        timerUi= GetComponent<TextMeshProUGUI>();
    }
}
