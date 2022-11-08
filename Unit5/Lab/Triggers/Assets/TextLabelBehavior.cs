using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public FloatData dataOBJ;
    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }
    public void UpdateLabel()
    {
        label.text = dataOBJ.value.ToString();
    }
}