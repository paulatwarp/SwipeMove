using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ForceMovement : MonoBehaviour
{
    [Tooltip("in m/s")] public float speed = 5.0f;
    Rigidbody physics;

    void Awake()
    {
        physics = GetComponent<Rigidbody>();
    }

    public void Move(float bearing)
    {
        Vector3 direction = Quaternion.AngleAxis(bearing, Vector3.up) * Vector3.forward;
        physics.AddForce(direction * speed - physics.velocity, ForceMode.VelocityChange);
    }
}
