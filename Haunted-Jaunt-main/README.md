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
  finessing then, I originally expected.

## New Particle Effect

- I used the ghostFOV and the dot product to trigger a new particle effect when John
  Lemon is seen by the ghosts. I added it to the prefab on his neck so it is extremely
  visable. I think it looks interesting.... I think I need to spend more time with the
  particle system.
- I know it also triggers through walls which is something I tried to fix, but I couldn't
  fix it.
- Triggered when the ghost sees john lemon based on the distance and FOV.

## New Sound Effect

- I also used the ghostFOV and the dot product to trigger a hissing sound effect when
  John Lemon is detected by the ghost. I wanted to make it very obvious to the player
  that the ghost is dangerous and is seeing them and to run away. The sound is played
  once per detection and plays along with the particle effect.
- I also made sure I used: AudioSource.PlayOneShot() to ensure it played without any
  disturbance. It was tricky and I had the add the audio source in the heirarchy as
  an object, and then in file path for me to be able to actually attach it. Also I
  had to attach it to the individual ghosts and not their prefabs or else the sound
  was not detected.

## Author

- Anthony Cano-Luna

## How to use everything

- Approach a ghost and step into its field of view. This triggers the particle and
  sound effect. The sound effect is a hissing sound.
- Move towards the Gargoyles and watch it turn from green to red.

## Resources from the internet

New audio source: https://pixabay.com/sound-effects/snake-hiss-95241/
