using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
}
