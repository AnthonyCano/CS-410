This is the README for the modifcations I made to the john lemon game.
New audio source: https://pixabay.com/sound-effects/snake-hiss-95241/

Things I added

## Dot Product

- I added a dot prodcut to the ghost in the GhostFOV.cs file. Essentially when the
  ghost detects when John Lemon is within a specified distance and detection range.
  This essentially allows the ghost to see the player which is then used to trigger
  a new sound and particle effect.

- It was implemented using: float dot = Vector3.Dot(transform.forward, directionToPlayer);

- You can't really see it is working unless you open the console where I am logging
  each time the ghost sees you and when it plays the sound.
