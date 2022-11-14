using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent StartEvent;
    public void Start()
    {
        StartEvent.Invoke();
    }
}
