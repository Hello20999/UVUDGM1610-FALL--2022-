using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLabelString : MonoBehaviour
{
    public Text label;
    public StringData dataobj;
    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }
    public void UpdateLabel()
    {
        label.text = dataobj.value.ToString();
    }
}
