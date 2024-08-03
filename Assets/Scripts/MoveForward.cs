using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToForward : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 0.05f;
    }
}
