using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    private ID otherID;
    private void OnTriggerEnter(Collider other)
    {
        var tempOBJ = other.GetComponent<IDContainerBehavior>();
        if (tempOBJ == null)
            return;
        var otherID = tempOBJ.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}
