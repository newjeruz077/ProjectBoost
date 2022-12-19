using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class RotationOscillator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
