Check with Jerald and create an array and store the beats in it, then iterate throw it in Void Update()

And the cube is not cutting sometimes - check and update it.

<hr>

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/NivxDoeS)
# Assignment 3: Making Beat Saber in Unity

[Beat Saber](https://beatsaber.com/) is widely considered to be one of the best and most successful virtual reality games. There is a free demo available for the Meta Quest 2, which you can find in the official store app. Before beginning this assignment, I suggest that you download this demo or watch some videos on YouTube to familiarize yourself with the gameplay.

In this assignment, you will be implementing Beat Saber's core mechanics. You can use Unity's built-in 3D objects (e.g. cubes) for this assignment, and you do not need to import custom meshes. If you want to make your game more interesting, you are also free to import additional assets or modify the appearance of the scene. Creativity is encouraged! However, note that your grade will be based on the interaction functionality, not the artistic quality of the game.

## Submission Information

You should fill out this information before submitting your assignment.  Make sure to document the name and source of any third party assets such as 3D models, textures, or any other content used that was not solely written by you.  Include sufficient detail for the instructor or TA to easily find them, such as a download link.

Name: Akash Reddy Jammula

UWM Email: ajammula@uwm.edu

Third Party Assets: No 3rd party assets

## My Submission based on Rubric

1. Done (2)
1. Cube gameObject destroyes when cut by blade (2)
1. ting-sound.mp3 plays when cube is destroyed (1)
1. Created a `CubeSpawner` that creates new cubes at random time intervals between 0.5 and 2.0 seconds. 
The cubes should starts at 12 units away from player(0,0,0), flys towards the user, and should be destroyed when hit by a laser sword. (3)
1. The exact X and Y positions of the spawned cubes are chosen randomly (2)
1. If a cube goes past the user, it touches the plane that is behind the player and gets destroyed.(2)
1. Added Arrow.png image on Quad which is on from of Cube. (3) 
> **Note**: the angle between blade and the top of the cube should be greater than 130degree
{Vector3.Angle((transform.position - previousControllerPosition), CubeGameObject.transform.up) > 130 => this condition added in script}
1. Randomly rotating the cube.  (2)
1. Red and Blue cubes are spawned, based on the colour player is able to cut them. (3)

**Bonus Challenge:** has 2 versions

Version 1: In main branch, added a beat variable for TheFatRat-Unity.mp3 song, which checks with a timer and spawns cubes.

Version 2: In Enhancements branch, https://github.com/UWM-COMPSCI790-F23/assignment-3-Akash3121/tree/enhancements
Added Dance-Monkey.mp3, added beats array with all the seconds, variable which checks time and plays for each beat. (2)


## Getting Started

Clone the assignment using GitHub Classroom.  The project has been configured for the Oculus Quest, and the Oculus Integration package has already been imported (still make sure to do the Oculus project setup step).  The project also contains the light saber created in Lecture 12.

## Rubric

Graded out of 20 points. 

1. Make a single cube that starts at the far end of the room and moves towards the user's start position.  Adjust the size and velocity so that it provides an appropriate challenge. (2)
1. When the user hits a cube with a laser sword, the cube should be destroyed. (2)
1. Play a sound when the cube is destroyed. There are plenty of websites for free sound effects.  You should find one that you like and import it into your project. (1)
1. Create a `CubeSpawner` that creates new cubes at random time intervals between 0.5 and 2.0 seconds.  You can feel free adjust these time thresholds to reach an appropriate difficulty.  The cubes should also start at the far end of the environment (>10 units away from the user), fly towards the user, and should be destroyed when hit by a laser sword. *Hint: you can create a prefab for the cube and then use `GameObject.Instantiate` to instantiate copies of it.* (3)
1. The exact X and Y positions of the spawned cubes should be chosen randomly, but should always be within reach of the user's swords when standing at the start position. (2)
1. If a cube goes past the user, it should also be destroyed, but no sound effect should be played.  We don't want to end up with infinite cubes that would slow down the Quest! (2)
1. Create a new material, and apply the `arrow.png` texture to it (found in the `Textures` directory). This material should then be applied to your cube, such that a single face (the one facing the user) has the arrow. [This YouTube video](https://www.youtube.com/watch?v=TfuoB_S8BM8) and Google will be your friend here. The cube should now have an arrow that indicates the direction in which to swing the sword.  Modify your script so that the cube is only destroyed when hit by a sword swung in that direction.  *Hint: you can use the velocity of the rigid body to determine the direction.*  (3)
1. When a cube is spawned, it should be rotated so that the direction of the arrow is either up, down, left, or right, selected randomly.  (2)
1. Finally, modify your `CubeSpawner` so that it spawns two different types of cubes, depending on the sword the user should hit them with.  For example, blue cubes could only be destroyed by the left sword, and red cubes could only be destroyed by the right sword. Finally, adjust the colors of each laser sword to match the cubes. *Hint: you can make a copy of the cube and sword materials and then change their colors in the object inspector.* (3)

**Bonus Challenge:** Transform your project into a real rhythm game!  Find a music track that you like and add it as an audio source in the scene.  Then, modify your `CubeSpawner` so that instead of spawning cubes randomly, the user will need to hit them according to the beat of the music.  You will need to store the time for spawning each cube in a data structure that the `CubeSpawner` can iterate through.  To accomplish this, you may want to play the music track in an external application such as [Audacity](https://www.audacityteam.org/) and make a list of times for each beat.  When you start playing the music, make sure to insert a delay to account for the time for the cubes to travel to the player.  You do not need to do this for the entire song; approximately 20-30 seconds of gameplay will be sufficient for bonus credit. (2)

Make sure to document all third party assets in your readme file. ***Be aware that points will be deducted for using third party assets that are not properly documented.***

## Submission

You will need to check out and submit the project through GitHub classroom.  **Make sure your APK file is in the root folder.** Do not remove the `.gitignore` or `README.md` files.

Please test that your submission meets these requirements.  For example, after you check in your final version of the assignment to GitHub, check it out again to a new directory and make sure everything opens and runs correctly.  You can also test your APK file by installing it manually using [SideQuest](https://sidequestvr.com/).

## Acknowledgements

This assignment is a modified version of an assignment from a class taught by Professor Evan Suma Rosenberg at the University of Minnesota.
