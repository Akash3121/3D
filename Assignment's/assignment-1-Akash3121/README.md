**My Assignment Details:-**

Scene: https://github.com/UWM-COMPSCI790-F23/assignment-1-Akash3121/blob/main/Assets/Scene1.unity

Scene contains: One sphere moves up and down which is relative to Cube, And a Capsule moves front and back which is above the camera. viewing angle(90degrees top to camera), and added a plan, tree, quad, sphere.

**Checkers(for final submission):**

- [x] Submission includes APK file - 2 pts 
- [x] Project runs on the Quest - 4 pts 
- [x] Scene contains at least four new objects - 2 pts {Contains 1 Sphere relative to 1 Cube, 1 Capsule, 1 Plane, 1 Tree, 1 Quad, 1 Sphere}
- [x] One of the objects is animated - 2pts {Capsule moving front and back, and Sphere moving up and down}

<hr>
[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)] (https://classroom.github.com/a/YLtOSuxU)

# Assignment 1: Getting Started with Unity

**Due: Thursday, September 28, 11:59pm CDT**

The purpose of the assignment is twofold:

1. Complete the setup of the virtual reality hardware and software that we will be using in this course.
2. Do a little work with Unity.

## Submission Information

You should fill out this information before submitting your assignment.  Make sure to document the name and source of any third party assets such as 3D models, textures, or any other content used that was not solely written by you.  Include sufficient detail for the instructor or TA to easily find them, such as asset store or download links. Also remember to document in your code wherever you use AI programming assistance.

Name: 

UWM Email:

Third Party Assets:

## Step 1: Oculus Account Setup

In order to build VR applications on the Oculus quest, you will need to create an Oculus developer account at: https://developer.oculus.com/. You may need a Meta account for this step, but should not need to link this account to any social media accounts.

Oculus will ask you to either enter a credit card number or enroll in 2 factor authentication for verification of your developer account. No automatic charges will be made to your card if you choose to go that route.

## Step 2: Oculus Organization Setup

Because Meta likes to make things unnecessarily complicated, your Oculus developer account also needs to be part of an organization.  The easiest way is for you to create one yourself. It is fairly simple, just follow the prompts. If you are uncomfortable with that, let me know and I can add you to mine. It is just not a very easy process to do, and has to be done manually, so it will take a bit of time.

You should now be able to activate developer mode on your headset (described in a later step).   Note that your Oculus user name is **not** the same as the email address associated with the account! 

## Step 3: Confirm Hardware Prerequisites

The Oculus Quest will also require that have access to the following:
1.	An Android or Apple mobile device for initial setup.  If you do not have a smartphone or tablet, it is possible to complete this step by borrowing one from another student.  I can also provide assistance if you need help with completing this step.
2.	A cable for connecting the headset to a computer.  Please note that the Quest comes with a USB-C to USB-C cable only.  If your computer does not have a USB-C port, then you may need to obtain a USB-C to USB cable.  If you have a newer smartphone with a USB-C charging port, then may already have a cable that will work.  However, if you are purchasing one, I recommend buying one that is advertised to work with Oculus Link.
3.	Batteries for the controllers.  It is highly recommended that you always have spare batteries ready in case they run out while you are in the middle of working on an assignment.

## Step 4: Headset Checkout

Hopefully by now everybody has checked out their headset. Please see me as soon as possible if you are unable to check one out.

## Step 5: Reset the Headset

If you turn on the headset and it appears that someone else is logged in, then the previous user most likely forgot to reset the headset after they were done.  In that case, I strongly recommend that you complete a factory reset before continuing further.  You can find instructions here:https://www.meta.com/help/quest/articles/fix-a-problem/troubleshoot-headsets-and-accessories/troubleshooting-factory-reset-quest/

After you reset the headset, you can follow the instructions in the box to complete the setup.  Please note that this will require installing the Oculus app on an Android or Apple mobile device and logging in with your Oculus account.  During this process, the headset will download the newest updates. 

## Step 6: Activate Developer Mode

1.	After you complete the setup process, you will need to enable developer mode.  On your mobile device, open the Oculus app and select the Quest device.  If you completed steps 1 and 2 of this assignment, then you will find a Developer Mode option under Headset Settings.
2.	After this step is completed, you will be able to build VR applications by connecting the Quest to a computer, and the mobile app is no longer necessary.
3.	If this is your first time using an Oculus device, it is recommended that you spend some time familiarizing yourself with using the controllers and navigating the menus.  There are also several free demo games in the Oculus store that you can download and try.

## Step 7: Unity Setup

In this class, we will be learning to develop VR applications using Unity. 

### Installing on your own computer

Download and install Unity Hub, available at the following link: https://unity3d.com/get-unity/download

The Hub application is useful for creating projects and managing installations of Unity.  For compatibility reasons, you will be **required** to use only the 2022.3 LTS (Long Term Support) version of Unity in this class.  You will also need to install the following modules, which can be added through Unity Hub:

1. Android Build Support
2. Android SDK & NDK Tools
3. OpenJDK

At the time of this writing, the most recent LTS version number is **2022.3.8f1**.  Note that the minor version number (8f1) may change during the semester if Unity releases an update.  Unfortunately, the projects are not backwards compatible.  If you install Unity at a later point in time, please make sure you install the *exact* version we are using in class.


## Step  8: Unity Tutorials (Optional)

Unity has a very large developer community, and there are extensive tutorials online at: https://learn.unity.com/

If you are unfamiliar with Unity, then you may want to get started by completing a basic tutorial such as [Unity Core Concepts](https://learn.unity.com/tutorial/learn-the-unity-core-concepts).  Note that these tutorials are completely optional and are not part of the assignment grade.  

## Step 9: Build and Deploy a VR Application

To complete this assignment, you are going to create a simple virtual environment and then deploy the application on the Oculus Quest.   If you get stuck on any of these steps, please watch the Lecture 3 video that walks through these steps.

1. Check out this assignment using GitHub classroom.  An empty Unity project has already been created for you.
1. Open the `SampleScene` under the Scenes folder. 
1. Under Build Settings, click "Add Open Scenes" to make this the default scene of your build. (Not necessary, but a good thing to do when you have projects with multiple scenes)
1. Add the [Oculus Integration Package](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) to your asset list (you will need to be signed into the same Unity account in browser as in Hubs).
1. In Unity, open the Package Manager window (Window -> Package Manager)
1. In the top left, switch the dropdown menu from "Packages: In Project" to "Packages: My Assets", and sort by Purchased date. This will take an unreasonable time to popuate and load.
1. Select "Oculus Integration", and download the package.
1. Import the package when it finishes downloading.
1. Once imported, you should have a new "Oculus" menu item, and a new "Oculus" folder in your Assets.
1. Select the "Oculus -> Tools -> Project Setup Tool" menu item and apply all of the fixes and suggested changes.
1. Select the "File -> Project Settings" menue item and navigate to the "Player" tab. Enter your name as the "Company Name" and the assignment title (Assignment 1) as the "Product Name" fields.  These will be used to identify the application after it is installed on the headset.
1. Navigate to the "Assets -> Oculus -> VR -> Prefabs" folder. Drag and drop the "OVRCameraRig" prefab to the scene heirarchy and delete the "Main Camera".
1. Build the APK file and deploy the project to your Quest headset.  You should save it as `Assignment-1.apk` in the same folder as the `README.md` file.  
1. The first time you try to build on a new computer, you may get an error that USB debugging is not enabled.  Put on the headset, and you will see a popup to authorize the computer.  
1. After the build process is complete, you can unplug the headset and put it on.  Your scene should be loaded automatically.  If not, your application is also installed on the Quest and will show up in the Library under Unknown Sources.
1. Test the application on your Oculus Quest.  If it works (e.g. your head movements are translated to the virtual environment), then congratulations... you have a working VR development pipeline!
1. Note that in the default scene, the controllers may not be visible when you open the application on the headset.  (They will actually appear under the floor.)  This is because the tracking origin is set incorrectly.  To fix this, click on the XRRig object in the sample scene.  In the object inspector, change "Requested Tracking Mode" from Default to Floor.  Rebuild the application, and the controllers should show up correctly.

## Step 10: Add Some Objects to the Scene

1.	Now, go back to Unity and add a few 3D objects to the scene (cubes, cylinders, spheres, etc.).
2.	Move each object to different location around the user.
3.	When you have added at least four objects to your scene, *Build and Run* the project again.  

## Step 11: Animate an Object

In this step, you are going to add a C# script that animates one of the 3D objects you created in the previous step.  You can make the object do anything you want, with the following requirements:

1. The object should use the `Update()` function to continuously move in every frame.  You can change the object's translation, rotation, scale, or any combination of the three.
2. The object should never move outside the user's view or disappear.  This means that you may need to make the animation cycle between two end points.

## Rubric

Graded out of 10 points. 

1. Submission includes APK file (2)
1. Project runs on the Quest (4)
1. Scene contains at least four new objects (2)
1. One of the objects is animated (2)

## Submission

You will need to check out and submit the project through GitHub classroom.  Make sure your APK file is in the root folder. Do not remove the `.gitignore` or `README.md` files.

If you are using Quest Link, pressing "Play" does not build the APK that is required for submission. You will still need to build the project through the "Build Settings" window.

Please test that your submission meets these requirements.  For example, after you check in your final version of the assignment to GitHub, check it out again to a new directory and make sure everything opens and runs correctly.  You can also test your APK file by installing it manually using [SideQuest](https://sidequestvr.com/) (see Devleopment Environment page on Canvas).

## Acknowledgement

This assignment is an edited version of an assignment created by Evan Suma Rosenberg, which was released under the CC BY-NC-SA 4.0 license.
  

