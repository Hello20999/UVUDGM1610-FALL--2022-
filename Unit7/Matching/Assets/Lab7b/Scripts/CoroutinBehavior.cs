using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutinBehavior : MonoBehaviour
{
    private bool canRun;
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    public intData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    public bool CanRun { get => canRun; set => canRun = value; }

    // Start is called before the first frame update
    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
    }
    public void StartScript()
    {
        startEvent.Invoke();
    }
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    IEnumerator Counting()
    {
        startCountEvent.Invoke();
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }
    public void StartRepeatUntilFalse()
    {
        CanRun = true;
        StartCoroutine(RepeatUntilFlase());
    }
    IEnumerator RepeatUntilFlase()
    {
        while (CanRun)
        {
            repeatUntilFalseEvent.Invoke();
            yield return wfsObj;
        }
    }
}
