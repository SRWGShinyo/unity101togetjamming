# Unity 101 To Get Jammin' Notes

## Introduction

This document will have all the links in plain from the slides 'Unity 101 To Get Jammin'. It will also give resources to learn. use it at your convenience

# Resources to Learn

* My Own playlist of tips: https://www.youtube.com/playlist?list=PL4w2KMmZHLj8F_fx8TAT8jFr_fny5cOKA  
* Brackeys: https://www.youtube.com/c/Brackeys
* BlackThornProd: https://www.youtube.com/c/Blackthornprod
* Unity Learn: https://learn.unity.com/
* CodeMonkey: https://www.codemonkey.com/
* Game Maker's Toolkit: https://www.youtube.com/c/MarkBrownGMT/videos  
* Mix and Jam: https://www.youtube.com/c/MixandJam  
* Sebastian Lague (for advanced algorithm): https://www.youtube.com/c/SebastianLague


# Links and addendi from the course

## What is Unity ?

### Links

*Unreal Engine:* https://www.unrealengine.com/en-US  
*Godot:* https://godotengine.org/  
*GameMakers Studio:* https://gamemaker.io/fr/gamemaker

## Unity Editor

### Links

*Download:* https://unity3d.com/fr/get-unity/download

## Unity Library and Game Objects

### Links

*Learn Quaternions the easy way*: https://www.youtube.com/watch?v=zjMuIxRvygQ  
*Vector3 API*: https://docs.unity3d.com/ScriptReference/Vector3.html  
*Quaternion API*: https://docs.unity3d.com/ScriptReference/Quaternion.html  
*GameObject API*: https://docs.unity3d.com/ScriptReference/GameObject.html  
*GameObject SetActive*: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html

## Unity Rendering

### Pipelines

- Built-in : the default one we will use. Default, easily plugged, but hardly customizable.
- Universal Render Pipeline: used for high customization and optimized graphics for all platforms
- HDRP: High-Definition Render Pipeline: high-fidelity graphics for high-end platforms

### Links

*Pipeline documentation*: https://docs.unity3d.com/Manual/render-pipelines-overview.html  
*Which Pipeline to choose*: https://www.youtube.com/watch?v=5MuA92xUJCA  
*Unity Material Documentation*: https://docs.unity3d.com/ScriptReference/Material.html  
*Meshes*: https://www.techtarget.com/whatis/definition/3D-mesh  
*Mesh Filters*: https://docs.unity3d.com/Manual/class-MeshFilter.html  
*Mesh Renderers*: https://docs.unity3d.com/Manual/class-MeshRenderer.html
*Sprites*: https://docs.unity3d.com/Manual/Sprites.html  
*Sprite Renderer*: https://docs.unity3d.com/ScriptReference/SpriteRenderer.html  
*Package Manager*: https://docs.unity3d.com/Manual/upm-ui.html
*Lighting*: https://docs.unity3d.com/Manual/Lighting.html

## Physics

### Links

*Joints*: https://docs.unity3d.com/Manual/joints-section.html  
*Physics*: https://docs.unity3d.com/Manual/PhysicsSection.html  
*Input*: https://docs.unity3d.com/ScriptReference/Input.html  
*Input System*: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/QuickStartGuide.html  
*Input Video*: https://www.youtube.com/watch?v=m5WsmlEOFiA  
*Destroy*: https://docs.unity3d.com/ScriptReference/Object.Destroy.html  
*GetComponent*: https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html  
*Animator*: https://docs.unity3d.com/ScriptReference/Animator.Play.html

## UI

*UI Toolkit*: https://docs.unity3d.com/Manual/UIElements.html   
*UI*: https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.UI.html  
*Anchors*: https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIBasicLayout.html  
*GameObject.SetActive*: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html  
*Component.enabled*: https://docs.unity3d.com/ScriptReference/Behaviour-enabled.html

## Audio

*Audio Mixer*: https://docs.unity3d.com/Manual/AudioMixer.html

## Build and Export

*Set up Android Environment*: https://docs.unity3d.com/Manual/android-sdksetup.html  
*Create your own HTML5 templates*: https://docs.unity3d.com/Manual/webgl-templates.html  
*SceneManager*: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html  
*LoadScene*: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html  

## Advanced Notions

### Explanation of the Coroutine

- In the start, we call the StartCoroutine function. **Calling a coroutine without it won't do anything !**
- We launch a while loop, until our object is scaled to 1
- We take the actual scale and add 0.01f (for a smooooth effect)
- We assign the new scale
- We use the yield to return a WaitForSeconds object
- We wait for 0.01f, once again, for smoothness

### Links

*Coroutines*: https://docs.unity3d.com/Manual/Coroutines.html 
*StartCoroutine*: https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html  
*DotWeen*: http://dotween.demigiant.com/  
*Camera*: https://docs.unity3d.com/ScriptReference/Camera.html  
*Post-Process for URP*: https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@7.1/manual/VolumeProfile.html  
*Cinemachine*: https://unity.com/fr/unity/features/editor/art-and-design/cinemachine  
*ShaderGraph*: https://unity.com/fr/features/shader-graph  
*VFX Graph* : https://unity.com/fr/visual-effect-graph && https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@8.2/manual/GettingStarted.html   
*Asset Store*: https://assetstore.unity.com/  
*Debug*: https://docs.unity3d.com/ScriptReference/Debug.html  
*Photon*: https://www.photonengine.com/pun  
*Player Prefs*: https://docs.unity3d.com/ScriptReference/PlayerPrefs.html  
*JsonUtility*: https://docs.unity3d.com/ScriptReference/JsonUtility.html  