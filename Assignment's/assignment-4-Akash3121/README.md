[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/D9PxbhAS)
# Assignment 4: Selection and Manipulation

In this assignment, you will implement several more advanced selection and manipulation techniques that were discussed in class.

## Submission Information

You should fill out this information before submitting your assignment.  Make sure to document the name and source of any third party assets such as 3D models, textures, or any other content used that was not solely written by you.  Include sufficient detail for the instructor or TA to easily find them, such as a download link. **Note that this assignment is a 3 week assignment**.

Name: Akash Reddy Jammula

UWM Email: ajammula@uwm.edu

Third Party Assets: No Third party assets

## My Submission Details
Added Joystick movement to left controller.

By default Fishing Reel Technique is active, 
  - used Clamp function so that when the RThumbstick is holded backwards continuously, the object will not go beyond the player
      - used 1.0f distance away from player as some objects are so big, if we used exactly players coordinates then the object is on us and sometime not able to see the other things, as this object is obstructing the view so clamped 1.0f away from player, so that it is right in front of the player.
   - If clicked on A or X then toggles between Fishing Reel and Go Go Technique
   -  Go Go Technique is added for both controllers.

Used 1 late point - submitting on 11/17/2023


## Getting Started

Clone the assignment using GitHub Classroom.  The project has been configured for the Oculus Quest, and the Oculus Integration package has already been imported. There is a scene titled "assignment4" in the Scenes folder that has a scene already created that you should use. This scene has a bunch of low-poly assets that create a playground. Pretty much all of the assets (except for the ground, rocks, grass, flowers, etc.) have a collider on them and a "grabbable" tag.

## Rubric

Graded out of 20 points. 

1. Add both controller objects and add joystick movement to the left controller thumbstick (you only need to implement virtual translation, not rotation). Implement a **Fishing Reel** variant of the pointing technique (see Lecture 13 slide 9) on the right controller. This should include a visible laser pointer that originates at the right controller. When it intersects an object with the "grabbable" tag and the user pulls the trigger, the object should be considered "grabbed" until the user lets go of the trigger (see Lecture 14).  When an object is grabbed, the user should be able to move the object by rotating the controller. That is, when a controller has a grabbed object, that object should always be the same distance from the controller along the controller's forward vector. In addition, the user should be able to translate the object forwards and backwards along the ray using the thumbstick (Similar to how the depth ray in Lecture 16). (5)
1. The user should be able to turn the Fishing Reel technique on and off using the A button on the right controller or the X button on the left controller.  Pressing either button should toggle the Fishing Reel technique. (1)
1. Implement the **Go-Go** grasping technique (see Lecture 11 slides 33,34) on both controllers.  This will involve computing the distance between each controller and the headset.  For distances less than some threshold *d*, the location of the controller should match the user's hand to allow them to easily grab nearby objects that have the "grabbable" tag.  For distances greater than *d*, the hand should be scaled forward to extend the user's reach.  You should experiment with different values for *d* and the distance scale factor to settings that work comfortably. Lecture 16 provides an example of using modifying the relationship between the virtual and physical controllers using a a gain parameter. This will be similar, but the gain paramter will depend on *d*. (4)
1. The user should be able to cycle between the Go-Go technique and the Fishing Reel technique using the A button on the right controller or the X button on the left controller.  When the Go-Go technique is deactivated, it should be deactivated for *both* hands. (2)
1. Implement a **Spindle** between the two controllers (see Lecture 13 slides 48, 49).  You should use a small object such as a cube to mark the midpoint. Add the spindle technique to the technique cycle. The spindle should only be active when the Fishing Reel and Go-Go technique is toggled off. That is, there should only be one active technique at a time. When the application starts, it should be the Fishing Reel technique. When either A or X is pressed, it should then be the Go-Go technique. When either A or X are pressed again, it should be the spindle technique. When either A or X are pressed again, it should go back to Fishing Reel. This should repeat. (2)
1. When the user grabs an object with the "grabbable" tag with either hand when the spindle is active, the object should be translated to the midpoint of the spindle. (2)
1. When the user moves their hands, the grabbed object should be translated to follow the midpoint of the spindle.  (2)
1. When the user moves their hands, the grabbed object should be rotated to match the alignment of the spindle.  Note that you only need to worry about yaw and roll (rotation about the Y and Z axes).  (2)
1. When the user moves their hands closer together or further apart, the grabbed object should be scaled up or down based on the distance between them.  (2)


Make sure to document all third party assets in your readme file. ***Be aware that points will be deducted for using third party assets that are not properly documented.***

## Submission

You will need to check out and submit the project through GitHub classroom.  **Make sure your APK file is in the root folder.** Do not remove the `.gitignore` or `README.md` files.

Please test that your submission meets these requirements.  For example, after you check in your final version of the assignment to GitHub, check it out again to a new directory and make sure everything opens and runs correctly.  You can also test your APK file by installing it manually using [SideQuest](https://sidequestvr.com/).

## Acknowledgments

The scene uses assets from the [Playground Low Poly](https://assetstore.unity.com/packages/3d/environments/playground-low-poly-191533) package from the Unity Asset Store. 

This assignment is a modified version of an assignment from a class taught by Professor Evan Suma Rosenberg at the University of Minnesota.   
