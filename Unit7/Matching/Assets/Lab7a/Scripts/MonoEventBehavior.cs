using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehavior : MonoBehaviour
{
    private bool tacos;
    public UnityEvent startEvent, awakeEvent, disableEvent, onMouseDownEvent, onMouseUpEvent, foodEvent;
    private void Awake()
    {
        awakeEvent.Invoke();
        tacos = false;
    }
    private void Start()
    {
        startEvent.Invoke();
    }
    private void OnDisable()
    {
        disableEvent.Invoke();
    }
    public IEnumerator OnMouseDown()
    {
        onMouseDownEvent.Invoke();
        tacos = true;
        yield return new WaitForSeconds(0.5f);
        Food();
    }
    private void Food()
    {
        if (tacos)
        {
            foodEvent.Invoke();
        }
    }
    private void OnMouseUp()
    {
        tacos = false;
        onMouseUpEvent.Invoke();
    }
}
