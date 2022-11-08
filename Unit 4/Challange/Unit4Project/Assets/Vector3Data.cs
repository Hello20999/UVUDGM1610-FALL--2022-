using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector2 value;
    public void UpdateValue(Vector2 sam)
    {
        value += sam;
    }
}
