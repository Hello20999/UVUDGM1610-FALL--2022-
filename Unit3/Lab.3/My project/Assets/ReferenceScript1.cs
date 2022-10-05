using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceScript1
//in reference to public v private variables
{
    public int apples;
    public int bananas;
    private int stapler;
    private int sellotape;
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }
    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
