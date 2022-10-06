using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamesAndTags : MonoBehaviour
    //how to give files tags and locate them
{
    GameObject player;
    GameObject chef;
    GameObject[] stoves;
    void Start()
    {
        player = GameObject.Find("MainHeroCharacter");
        chef = GameObject.FindWithTag("Chef");
        stoves = GameObject.FindGameObjectsWithTag("Stove");
    }
}
