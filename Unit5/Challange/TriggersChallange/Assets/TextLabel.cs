using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabel : MonoBehaviour
{
    public Text label;
    public IntData dataOBJ;
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