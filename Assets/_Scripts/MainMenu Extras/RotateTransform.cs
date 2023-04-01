using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTransform : MonoBehaviour
{

    public float speed = 3f;

    private void Update()
    {
        transform.Rotate(Vector3.up, speed);
    }

}
