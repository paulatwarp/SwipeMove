# Swipe Input

## DetectSwipe

The `DetectSwipe` script detects mouse click and drag operations. Unity will map the first finger touch and drag to the mouse input, so this should work to detect finger swipes on mobile devices. The public `deadzone` parameter allows you to adjust the amount you have to move in screen pixels to detect an input.

### Member Variables

```csharp
public float deadzone;
```

|          |                                                                   |
|----------|-------------------------------------------------------------------|
| deadzone | the minimum movement required to detect an input in screen pixels |

### Public Unity Events

```csharp
public UnityEvent onSwipeLeft;
public UnityEvent onSwipeRight;
public UnityEvent onSwipeUp;
public UnityEvent onSwipeDown;
```

These events are triggered when the respective swipe inputs are detected.

## Example Scene

This scene has a single text box. The `SwipeInput` script is attached to an empty object and each swipe event is set to change the text of the text box to describe the detected input. To activate it, click anywhere within the window and drag in the required direction. The detection happens when the mouse is released.