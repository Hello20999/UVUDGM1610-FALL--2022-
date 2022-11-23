using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> ColorIDList;
    public ColorID currentColor;
    private int num;
    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, ColorIDList.Count);
        currentColor = ColorIDList[num];
        Debug.Log(num);
    }
}
