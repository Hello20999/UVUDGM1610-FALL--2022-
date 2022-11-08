using UnityEngine;
using UnityEngine.Events;

public class CircleMonoTrigger : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent, onEnabled, onParticleCollision, onMouseExit;
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
        disableEvent.Invoke();
    }
    private void OnEnable()
    {
        onEnabled.Invoke();
    }
    private void OnParticleCollision(GameObject other)
    {
        onParticleCollision.Invoke();
    }
    private void OnMouseExit()
    {
        onMouseExit.Invoke();
    }
}
