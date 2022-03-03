# Swipe Control

## Example Scene

This scene has a ball within four walls. The physics materials have no friction or bounce values. This means the objects will frictionlessly slide and stop as soon as they hit an obstacle. The ball has a `Rigidbody` with rotation frozen so it doesn't roll.

The `SwipeInput` script calls the `Move` function of the `ForceMovement` script attached to the ball object. The following directions are mapped:

| swipe direction | movement bearing (degrees) |
|-----------------|---------------------------:|
| up              | 0                          |
| left            | -90                        |
| down            | 180                        |
| right           | 90                         |
