using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 scale = Vector3.one * _speed;

        transform.localScale += scale;
    }
}
