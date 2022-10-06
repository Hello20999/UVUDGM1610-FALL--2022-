using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//how to save data to script obj
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class ScritableObjects : MonoBehaviour
{
    public string prefabName;
    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}
