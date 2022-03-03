# Slide Movement

## ForceMovement

The `ForceMovement` script adjusts the velocity of the attached `Rigidbody` given a global bearing in degrees. The public `speed` parameter allows you to set the speed of the movement in metres per second.

### Member Variables

```csharp
public float speed;
```

|         |                                                  |
|---------|--------------------------------------------------|
| speed   | speed of movement in metres per second           |

### Public Member Functions

```csharp
public void Move(float bearing);
```

Change the velocity of the attached `Rigidbody` to the given `bearing` in degrees. The `speed` member variable sets the speed for the new velocity vector.

#### Parameters

|         |                                                  |
|---------|--------------------------------------------------|
| bearing | bearing for the direction of movement in degrees |

## Example Scene

This scene has a ball within four walls. The physics materials have no friction or bounce values. This means the objects will frictionlessly slide and stop as soon as they hit an obstacle. The ball has a `Rigidbody` with rotation frozen so it doesn't roll.

The `KeyInput` script applies movement in directions: `0`, `-90`, `180`, `90`, for the keys: `W`, `A`, `S`, `D` respectively.
