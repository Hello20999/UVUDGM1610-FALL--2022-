using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreateInstance()
    {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (Vector3Data v in obj.vector3DataList)
        {
            Instantiate(prefab, v.value, Quaternion.identity);
        }
    }
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3DataList[num].value, Quaternion.identity);
        num++;
        if (num == 4)
        {
            num = 0;
        }
    }
    public void CreateInstanceFromListRandom(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DataList.Count);
        Instantiate(prefab, obj.vector3DataList[num].value, Quaternion.identity);
    }
}
