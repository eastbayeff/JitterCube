using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotator : MonoBehaviour
{
    public float Speed = 3f;

    private Rigidbody rb;

    void Awake() => rb = GetComponent<Rigidbody>(); 

    void FixedUpdate() => rb.angularVelocity = transform.forward * Speed;
}
