using UnityEngine;

public class ObjectMoveToForward : MonoBehaviour
{
    private void Update()
    {
        float speed = 0.05f;

        transform.position += transform.forward * speed *Time.deltaTime;
    }
}
