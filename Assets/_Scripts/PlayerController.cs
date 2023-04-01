using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 15;

    private Rigidbody rb;
    private Vector3 movement;

    void Awake() => rb = GetComponent<Rigidbody>();
    
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * Speed, ForceMode.Impulse);
    }
}
