using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    private void Awake()
    {
        awakeEvent.Invoke();
    }
    private void Start()
    {
        startEvent.Invoke();
    }
    private void OnDisable()
    {
        startEvent.Invoke();
    }
}