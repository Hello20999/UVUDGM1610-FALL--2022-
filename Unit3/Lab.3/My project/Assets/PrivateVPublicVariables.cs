using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivateVPublicVariables : MonoBehaviour
{
    public int alpha = 5;
    private int beta = 0;
    private int gamma = 5;
    private ReferenceScript1 myOtherClass;
    /*
     * public used to use in diffrent class, or used in another script
     * private is only to be used within the class its set in
     * */
    void Start()
    {
        alpha = 29;
        myOtherClass = new ReferenceScript1();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    //referencing another script
    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
