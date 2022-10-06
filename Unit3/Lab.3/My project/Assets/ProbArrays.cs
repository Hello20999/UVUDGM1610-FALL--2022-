using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbArrays : MonoBehaviour
{
    void Start()
    {
        //choosing randomly in an array
        //`var element = myArray[Random.Range(0, myArray.Length)];`` 

        //prob, with diffrent prob for each chance
        float Choose(float[] probs)
        {
            float total = 0;
            foreach (float elem in probs)
            {
                total += elem;
            }
            float randomPoint = Random.value * total;
            for (int i = 0; i < probs.Length; i++)
            {
                if (randomPoint < probs[i])
                {
                    return i;
                }
                else
                {
                    randomPoint -= probs[i];
                }
            }
            return probs.Length - 1;
        }

        //prob, with some part being more weighted than others
        float CurveWeightedRandom(AnimationCurve curve)
        {
            return curve.Evaluate(Random.value);
        }

        //creates a random order for an array
        void Shuffle(int[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                int temp = deck[i];
                int randomIndex = Random.Range(i, deck.Length);
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }

        //creating a random prob, while reaching for a desired outcome
        Transform[] spawnPoints;
        Transform[] ChooseSet(int numRequired)
        {
            Transform[] result = new Transform[numRequired];
            int numToChoose = numRequired;
            for (int numLeft = spawnPoints.Length; numLeft > 0; numLeft--)
            {
                float prob = (float)numToChoose / (float)numLeft;
                if (Random.value <= prob)
                {
                    numToChoose--;
                    result[numToChoose] = spawnPoints[numLeft - 1];
                    if (numToChoose == 0)
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
