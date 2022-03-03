using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public ForceMovement target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            target.Move(0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            target.Move(180.0f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            target.Move(-90.0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            target.Move(90.0f);
        }
    }
}
