using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, matchDelayedEvent, noMatchEvent, noMatchDelayedEvent;
    private WaitForSeconds wfsObj;
    private float seconds = 0.3f;
    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempOBJ = other.GetComponent<IDContainerBehavior>();
        if (tempOBJ == null)
            yield break;
        var otherID = tempOBJ.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
            yield return wfsObj;
            matchDelayedEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return wfsObj;
            noMatchDelayedEvent.Invoke();
        }
    }
}
