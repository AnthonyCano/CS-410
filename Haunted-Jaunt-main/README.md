This is the README for the modifcations I made to the john lemon game.
New audio source: https://pixabay.com/sound-effects/snake-hiss-95241/

Things I added

## Dot Product

- I added a dot prodcut to the ghost in the script: "GhostFOV.cs". Essentially when the
  ghost detects when John Lemon is within a specified distance and detection range.
  This essentially allows the ghost to see the player which is then used to trigger
  a new sound and particle effect.
- It was implemented using: float dot = Vector3.Dot(transform.forward, directionToPlayer);
- You can't really see it is working unless you open the console where I am logging
  each time the ghost sees you and when it plays the sound.
- This component was added to the ghost prefab so I could easily add them.

## Linear Interpolation

- I basically added a feature where the gargoyles change color from green to red if
  the player gets within a certain distance. I meant it for indicate when you can
  move around them safely and when you should be careful.
- This was added in the script "EnemyGlowEffect.cs", and implemented with:
  Color lerpColor = Color.Lerp(closeColor, farColor, t);
- Like the FOV for the ghost this was added to the gargoyle prefab, and took more
  finessing then, I orginally expected.
