using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    List<string> list = new List<string> { "ace", "king", "queen", "clover", "heart", "diamond", "spade" };
    private void Start()
    {
        Debug.Log("Here is the original list " + string.Join(", ", list));
    }
    void Shuffle<T>(List<T> card)
    {
        for (int i = 0; i < card.Count; i++)
        {
            T temp = card[i];
            int randomIndex = Random.Range(i, card.Count);
            card[i] = card[randomIndex];
            card[randomIndex] = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shuffle(list);
            Debug.Log("");
            Debug.Log("here is the new list " + string.Join(", ", list));
            Debug.Log("I win again");
            Debug.Log("");
        }
    }
}
//note for self, the string.join combine the list and the "", so it will break up the list with commas
/*note for self, do not put void shuffle in start, it function as its own class
 * also, List<sting> list needs to be outside of everything, or else list will be private and can't be accessed for the void update()*/