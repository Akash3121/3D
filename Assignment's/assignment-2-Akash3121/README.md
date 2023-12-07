[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/9ZF4vhGG)
# Assignment 2: Create a Virtual Environment and Basic Interactions

Class: COMPSCI 657/790 Immersive Technologies and 3D User Interfaces

Professor: Jerald Thomas

## Overview

The purpose of this assignment is two-fold. The first reason is for you to gain experience creating virtual environments in Unity. The second is to create a basic interaction technique using the Quest 2. Your goal is to create your own virtual environment using free 3D art assets found on the web. Some of the assets will be able to be picked up by the user, and even thrown.  If you get stuck on any of the steps in this assignment, you should go back and watch the video for Lectures 5 and 7 (they can be found on Canvas). The "Throwing Demonstration" video on Canvas shows the expected interaction behavior.

Creativity is encouraged!

## Submission Information

You should fill out this information before submitting your assignment.  Make sure to document the name and source of any third party assets such as 3D models, textures, or any other content used that was not solely written by you.  Include sufficient detail for the instructor or TA to easily find them, such as a download link.

Name: Akash Reddy Jammula

GitHub ID: Akash3121
  
UWM Email: ajammula@uwm.edu

Third Party Assets:
- Low Poly Tree Pack: https://assetstore.unity.com/packages/3d/vegetation/trees/low-poly-tree-pack-57866
- Animated Goat and Sheep 3D low poly free: https://assetstore.unity.com/packages/3d/characters/animals/animated-goat-and-sheep-3d-low-poly-free-251910
- Low Poly Rock Pack: https://assetstore.unity.com/packages/3d/environments/low-poly-rock-pack-57874
- Free Low Poly Human - RPG Character: https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/free-low-poly-human-rpg-character-219979
- Low Poly Simple Nature Pack: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153
- Sky box series free - for downloading sky: https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-series-free-103633

#### My Submission based on Rubric.

1) Done created a scene and added OVRCameraRig and OVRControllerPrefabs and added the Joystick movement script(2) {Note: left controller has very high throwForce than rightController}
2) Added around 25+ objects to the scene with trees, rocks, sheeps, goats, mushrooms, and a human too. (2)
3) Added a sky (1)
4) Added a "Grabber" script to both the LeftHandAnchor and RightHandAnchor in the OVRCameraRig heirarchy (2)
5)  Grabbable & throwable items:  (2)
    1) Rock Type2 03
    2) Rock Type1 04
    3) Rock Type2 04
    4) Rock Type6 04
    5) Stump_01
    6) Branch_01 
6) Added Velocity (1)

## Getting Started

Clone the assignment using GitHub Classroom. The project has been configured for the Oculus Quest by importing select portions of the Oculus Intergration Package. However, the project does not contain a scene file.  Your goal is to create a new scene using free 3D art assets found on the web, with the following requirements:

- The objects in the scene should be imported art assets.  You cannot use the basic 3D objects in Unity, such as cubes, spheres, cylinders, etc. 
- Do not simply use an already completed demo scene from an asset package.  The goal here is for you to construct your own scene.
- The environment should be an outdoor scene.  
- The assets should display smoothly on the Oculus Quest.  This means you should specifically look for **low poly** assets that are appropriate for rending on a mobile graphics processor.  Make sure to test them to make sure everything runs well!
- You are free to use any legal sources for third party assets, including the [Unity Asset Store](https://assetstore.unity.com/).  Alternatively, you can also locate and export game assets from websites such as [Clara.io](https://clara.io/) or [TurboSquid](https://www.turbosquid.com/Search/3D-Models/free). You are not expected to pay for assets, you should only use free assets.

## Rubric

Graded out of 10 points. 

1. Create a new scene. The ground can either be a textured plane or an imported mesh with more complex geometry. Add the OVRCameraRig and OVRControllerPrefabs, as shown in Lecture 5. Also add the movement script from Lecture 5 to the OVRCameraRig object. (2)
1. Now, add an assortment of 3D objects to the scene.  The environment should also contain *at least* six unique objects that were downloaded on the web. These objects should be placed in the environment to form a plausible scene. Three of the objects should be selected to be interactable, that is they should be properly sized (not too large or too small). (2)
1. Add a [skybox](https://medium.com/nerd-for-tech/tip-of-the-day-skybox-101-in-unity3d-d0b043ece592) to the scene. You can find plenty of skybox textures on the asset store. (1)
1. Create and add a "Grabber" script to both the LeftHandAnchor and RightHandAnchor in the OVRCameraRig heirarchy. Also add properly sized trigger colliders. Using the script I programmed in class in Lecture 7 is fine. (2)
1. Select three of the objects from your scene to be grabbable and add the appropriate game components to them (see Lecture 7). These objects should be able to be picked up and let go. When picked up, they should follow the controller, and when let go, they should fall to the floor under the influence of simulated gravity. The interactable objects should be fairly obvious and easy to get to. (2)
1. Edit your "Grabber" script so that when the object is let go, it calculates the velocity with which it was let go and applies it to the object's RigidBody. This will result in throwing behavior. You may need to add an ampflication variable to the velocity vector (in the video on canvas I used an amplifier of 2.0), just play with it until it feels right. Hint: to calculate the velocity, you will need to keep track of the last frame's controller position, and use the time delta between the last and current frame. (1)



Make sure to document all third party assets in your readme file. ***Be aware that points will be deducted for using third party assets that are not properly documented.***

## Submission

You will need to check out and submit the project through GitHub classroom.  **Make sure your APK file is in the root folder.** Do not remove the `.gitignore` or `README.md` files.

Please test that your submission meets these requirements.  For example, after you check in your final version of the assignment to GitHub, check it out again to a new directory and make sure everything opens and runs correctly.  You can also test your APK file by installing it manually using [SideQuest](https://sidequestvr.com/).

