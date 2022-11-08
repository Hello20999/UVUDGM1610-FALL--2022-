using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLabelInt : MonoBehaviour
{
    public Text label;
    public IntData dataOBj;
    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }
    public void UpdateLabel()
    {
        label.text = dataOBj.value.ToString();
    }
}
