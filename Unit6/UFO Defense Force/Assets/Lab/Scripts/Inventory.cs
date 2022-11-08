using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public float value;
    public void UpdateValue(float num)
    {
        value += num;
    }
}
