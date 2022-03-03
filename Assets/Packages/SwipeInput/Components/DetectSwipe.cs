using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectSwipe : MonoBehaviour
{
    [Tooltip("in screen pixels")] public float deadzone = 10.0f;
    Vector3 startPosition;

    public UnityEvent onSwipeLeft;
    public UnityEvent onSwipeRight;
    public UnityEvent onSwipeUp;
    public UnityEvent onSwipeDown;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 direction = Input.mousePosition - startPosition;
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                if (direction.x < -deadzone)
                {
                    onSwipeLeft.Invoke();
                }

                if (direction.x > deadzone)
                {
                    onSwipeRight.Invoke();
                }
            }
            else
            {
                if (direction.y > deadzone)
                {
                    onSwipeUp.Invoke();
                }

                if (direction.y < -deadzone)
                {
                    onSwipeDown.Invoke();
                }
            }
        }
    }
}
