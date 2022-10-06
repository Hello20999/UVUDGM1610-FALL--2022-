using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingShapes : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        // Draw a magenta cube at the transform position
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, new Vector3(3, 2, 1));
    }
}
