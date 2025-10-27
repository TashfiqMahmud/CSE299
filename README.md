Update 2:         Course CSE299.4              Group 5

Project Functionality Summary (Contributor: Tashfiq Mahmud)

Audio Implementation (Music & Sound Design)

This module was responsible for designing and implementing the entire auditory experience, ensuring player immersion and thematic consistency. This involved integrating multiple background music tracks that loop and transition dynamically to maintain the retro-futuristic synthwave mood. Furthermore, a comprehensive set of game sound effects (SFX) was sourced and integrated, covering critical player feedback moments such as coin collection, jump actions, collision impact, and power-up activation. This work provides essential auditory cues, enhancing both player feedback and overall engagement.

Project Functionality Summary (Contributor: Tamanna Akter)

3d asset & skybox (visualize atmosphere of the grid) 

This module was responsible for integrating the foundational 3D assets and establishing the primary game environment. This involved importing core models, including the Coin collectible and the main Sculpt.obj obstacle, along with setting up the foundational Player.controller asset. Furthermore, the Free stylized skybox materials and textures were successfully integrated and applied to the scene to establish the retro-futuristic and thematically consistent visual atmosphere of The Grid. This work finalizes the structural and visual base required for the procedural generation engine. 

Project Functionality Summary (Contributor: Ihtishamul Haq)

Prefabs and Small Buildings

This module focused on creating and implementing modular road systems and small building prefabs to enhance the structural design of the game environment. The road prefabs were modeled and aligned for seamless procedural placement, allowing smooth player navigation across levels. Small building prefabs were designed to add depth and realism to the scene. Together, these assets form the foundational layout for the cityscape, contributing significantly to the world-building and overall immersion.

Project Functionality Summary (Contributor: Tirana Mahbub)

Packages and TextMesh Pro

The Packages file manages Unity’s dependencies and ensures the game runs with the correct tools and libraries. It specifies which Unity packages are used, such as rendering, input, or physics systems, and locks their versions for stable performance across all devices. The TextMesh Pro file provides advanced text-rendering features in the game for precise control over typography. It supports effects like color gradients, outlines, shadows, bold and italic styles, and high-quality scalable text. These files maintain the project’s stability and enhance the visual quality of text and interface elements in the game.

Update 1:         Course CSE299.4              Group 5

Project Functionality Summary (Contributor: Tashfiq Mahmud)

This module focused on implementing the core visual and animation systems for the main player character and essential in-game collectibles in the endless runner environment. Specifically, the code defines the Player’s animation state machine (Player.controller), which manages key movement visuals. This system allows the Player to smoothly transition between the Default (Running/Idle) state and reactive states for Jump and Slide based on boolean input parameters. Additionally, a continuous, perpetual animation was created for the Collectible Coin entity. The Coin utilizes a 3-second looping rotation around the Y-axis (Coin.anim and Coin.controller), ensuring the collectible has a constant, visually engaging spinning effect in the game world. The completed work provides the essential dynamic visual feedback necessary for player movement and object engagement.

Project Functionality Summary (Contributor: Tamanna Akter)

Technical Aesthetics (Materials & Shaders): 

The Material Folder defines the Player's visual properties, specifically configuring the player.mat file to use a highly reflective, glowing shader that achieves the project's electric blue/cyan synthwave aesthetic. The Shaders Folder contains the custom shader logic (CurvedCode.cginc) that manipulates world geometry to create the illusion of a perpetually curved, bending highway, directly supporting the high-fidelity 3D procedural environment objective.

Project Functionality Summary (Contributor: Ihtishamul Haq)

The Joystick Pack is the main input system, providing prefabs and scripts for responsive on-screen controls essential for mobile and touch-based gameplay. To add one, drag a prefab (like Fixed, Floating, Dynamic, or Variable) from the Joystick Pack/Prefabs folder into a Canvas. You can fine-tune its feel using properties like Handle Range and access live input values through functions like Horizontal and Vertical. This system is key to making the project immersive and intuitive by offering customizable and precise player movement control.

Project Functionality Summary (Contributor: Tirana Mahbub)

The Scenes folder in this project contains the main Unity scenes and their supporting assets. It includes Main.unity, likely serving as the main menu or starting scene, and Game.unity, which represents the core gameplay scene. Inside the Game subfolder is Global Volume Profile.asset, which configures the scene’s visual and post-processing effects, such as lighting, color grading, and camera effects. Every asset, including the scenes and volume profile, has an associated .meta file (like .unity.meta or .asset.meta) that stores Unity’s internal metadata, including unique identifiers (GUIDs) and import settings, ensuring assets remain correctly referenced and version-controlled. The Game_Profiles.meta file appears to manage or link additional game-related configurations. Together, these files define both the gameplay and visual structure of the project while maintaining Unity’s internal references and consistency across the project.

