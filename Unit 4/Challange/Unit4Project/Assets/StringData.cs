using UnityEngine;
[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;
    public void UpdateValue(string gum)
    {
        value += gum;
    }
}
