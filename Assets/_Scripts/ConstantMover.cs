using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMover : MonoBehaviour
{
    public float Speed = 10;

    private Rigidbody rb;

    void Awake() => rb = GetComponent<Rigidbody>();
    
    void FixedUpdate() => rb.velocity = Speed * transform.forward;
}
