using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        var nextPosithion = transform.position;
        nextPosithion.x += 0.05f;
        transform.position = nextPosithion;
    }
}
