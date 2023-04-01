using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jitter : MonoBehaviour
{
    public float JitterVariation = 2f;

    void Update() => transform.position = Random.insideUnitSphere * JitterVariation;
}
