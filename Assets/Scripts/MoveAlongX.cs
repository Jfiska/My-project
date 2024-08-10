using UnityEngine;

public class ObjectMoveAlongX : MonoBehaviour
{
    private void Update()
    {
        float speed = 0.05f;

        var nextPosithion = transform.position;
        nextPosithion.x += speed;
        transform.position = nextPosithion;
    }
}
