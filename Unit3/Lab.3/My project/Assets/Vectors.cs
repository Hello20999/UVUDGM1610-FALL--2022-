using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//some function are disabled due to error for missing objects
public class Vectors : MonoBehaviour
{
    void Start()
    {
        //Vectors are movement in a grid like movement,  below is a function ending in an grid coordinate
        //var pointInAir = pointOnGround + new Vector2(0, 5);
        
        var a = 3;
        var b = 3;
        //here to prevent errors
        
        //vector subtraction to make coordinates
        var c = b - a;
        var d = a - b;
        var f = a - b;
        var g = a + -b;

        //gets the point that directly towards the object
        //var heading = target.position - player.position;

        //normalizing a vectore
        var distance = heading.magnitude;
        var direction = heading / distance;

        //using vectors to check if target is a certain distant away
        /*if (heading.sqrMagnitude < maxRange * maxRange)
        {
            
        }*/

        //how to gain vectore above the ground, and have it look at it from ground level
        /*var heading = target.position - player.position;
        heading.y = 0;*/

        //used to calculate mutiple vectors in comparison
        //var fwdSpeed = Vector3.Dot(rigidbody.velocity, transform.forward);

        //used to calculate new vectors
        /*
        Vector3 a;
        Vector3 b;
        Vector3 c;
        Vector3 side1 = b - a;
        Vector3 side2 = c - a;
        Vector3 normal = Vector3.Cross(side1, side2);*/

        //another way to normalize a vector
        /*float perpLength = perp.magnitude;
        perp /= perpLength;*/
    }
}
