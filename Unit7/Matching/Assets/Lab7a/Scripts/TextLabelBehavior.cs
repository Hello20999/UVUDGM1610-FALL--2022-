using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    private Text label;
    public UnityEvent startEvent;
    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }
    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString();
    }
    public void UpdateLabel(intData obj)
    {
        label.text = obj.value.ToString();
    }
}
