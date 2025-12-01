Project Video 6: https://youtu.be/RhQ0227ugDQ

Project Video 5: https://youtu.be/ujQa_sYotkY

Project Video 4: https://youtu.be/q2IQnO7BmN4

Project Video 3: https://youtu.be/qr4y2gQMEdU

Project Video 2: https://youtu.be/JVu6ad_eSE8

Preject Video 1: https://youtu.be/97PvFzanUd4


Update 6:         Course CSE299.4              Group 5 
 
Project Functionality Summary (Contributor: Tashfiq Mahmud)
This week, I finalized core player and level systems, establishing the foundation for continuous gameplay. I implemented robust character physics, enabling smooth forward movement and accurate lane changing, and integrated turn triggers to handle dynamic directional shifts. I ensured stable player tracking during all movements using the CameraFollow.cs script. I set up the GameManager to use precision offsets to generate a seamless, continuous path of road geometry. Finally, I made structural improvements that enabled the successful placement of rotating coins on the track, preparing the game for collection logic.

Project Functionality Summary(Contributor: Tamanna Akter Mou & Ihtishamul Haq) 
This week, we focused on documenting and visualizing our overall development progress by creating a complete, structured vertical flowchart for the Vapor Drift project. We analyzed the gameplay videos, team tasks, and implemented features to accurately map each development stage—from asset integration to movement systems, UI flow, and advanced mechanics like Boost and Phase-Shift. The flowchart organizes every milestone in chronological order, showing how each system connects to the next, ensuring clear visibility of the project’s technical progression. This visual documentation improves team communication, helps identify dependencies, and serves as a polished representation of our collective work for reports and presentations. This flowchart will guide us for the next development steps and make future updates easier to track.

Project Functionality Summary (Contributor: Tirana Mahbub) 
I developed some game features by adding a main menu scene and connecting it to the gameplay scene for smooth navigation. I created the main menu scene by adding sufficient customizations, buttons, images etc. The player’s forward movement was fixed so the character now moves continuously. A pause menu was created using Unity UI with Resume and Quit buttons that can quit and resume the game using time-scaling. Required C# scripts were added during the tasks. These improvements created a stable flow between the MainMenu scene and the Game scene and made the game easier to control.


Update 5:         Course CSE299.4              Group 5 

Project Functionality Summary (Contributor: Tashfiq Mahmud)
I've completed the core foundation for my endless runner prototype. I successfully implemented the Player's running animation and built the central Level Spawning System using a dedicated LevelSpawner manager. I created four unique Chunk Prefabs and customized materials, including the green playground area. I set up the critical EndMarker triggers on all chunks, ensuring seamless, continuous, and random track generation as I move forward. I am now prepared to focus on creating additional Chunk Prefabs for content variety.

Project Functionality Summary(Contributor: Tamanna Akter Mou & Ihtishamul Haq) 
This week, our main contribution was creating a detailed flowchart based on our game project video. We watched the full gameplay recording and converted all the steps into a clear vertical flowchart, showing how the game starts, loads assets, initializes the player, and generates the procedural track. We also explained gameplay elements such as lane switching, collectibles, near-miss events, boost activation, and phase-shift mechanics. The flowchart shows the full gameplay loop, including collision checks, game-over logic, scoring, and difficulty scaling. By mapping everything visually, we helped our team understand the current progress and identify the core systems already implemented. This flowchart will guide us for the next development steps and make future updates easier to track.

Project Functionality Summary (Contributor: Tirana Mahbub) 
This week, I worked on writing the Proposed Solutions Report for Vapor Drift. I tried to identify the common issues in existing games and explained how our game will improve them. I described how we can possibly reduce repetition using procedural track chunks, add more skill-based features like near-miss rewards and make gameplay more strategic with energy-based obstacle passing. I also covered technical improvements such as object pooling, optimized shaders and simplified physics to keep the game lag-free. We are trying to strengthen the game’s identity by expanding the synthwave world “The Grid” and made a player-friendly monetization plan with optional ads and cosmetic-only purchases. Overall, my contribution this week was creating a clear plan to make the game more unique, polished and enjoyable.
 



Update 4:         Course CSE299.4              Group 5 
 
Project Functionality Summary (Contributor: Tashfiq Mahmud)
This project presents a literature review on the Endless Runner game genre. It examines the genre’s origins, purpose, and evolution through popular titles like Canabalt, Temple Run, and Subway Surfers. The study analyzes why the genre was created, its success factors, and its current popularity in the mobile gaming market. My contribution includes collecting and summarizing research materials, identifying key problems the genre addressed, and designing a presentation that highlights major findings and trends. The review concludes that endless runners remain influential but face challenges of innovation and market saturation.

Project Functionality Summary(Contributor:Tamanna Akter Mou) 
User Settings Finalization
This week, I focused on setting up and organizing the Unity User Settings to ensure a smooth and consistent development experience for the team. Key configuration files such as EditorUserSettings.asset, Search.settings, and default-2021.dwlt were updated and added to the project.These files help maintain a uniform editor layout, improve asset search efficiency, and preserve personalized editor preferences. This setup will support faster development, reduce configuration issues, and keep the workflow consistent across all team members. In addition, standardizing these settings ensures that all contributors view the same workspace layout when opening the project, reducing confusion during scene editing. Search filters were also refined to make it easier to locate scripts, prefabs, and materials quickly. This update serves as a foundation for better collaboration and streamlined development in future stages of the project.

Project Functionality Summary (Contributor: Ihtishamul Haq & Tirana Mahbub) 
Script Integration
This week, our primary focus was on adding and integrating the core C# scripts for Vapor Drift. These scripts form the backbone of the game’s functionality and control systems, enabling smooth gameplay and interaction between different components.We uploaded and organized several key scripts, including AudioManager, CameraFollow, GameManager, Player_Movement, LifeManager, Sound, and others. Each script plays an important role in handling specific mechanics such as player movement, camera behavior, audio management, game state control, and in-game interactions. Corresponding .meta files were also added to ensure proper recognition and linking within Unity’s asset system.
This update was an essential step in establishing the game’s core logic and functionality, laying the groundwork for future modules like gameplay tuning, UI interaction, and level progression.



Update 3:         Course CSE299.4              Group 5 
 
Project Functionality Summary (Contributor: Tashfiq Mahmud & Tamanna Akter Mou) 

Project Settings Finalization

This module was responsible for finalizing the Project Settings to establish the comprehensive technical groundwork necessary for the demanding performance and structural requirements of a high-fidelity 3D endless runner. This involved configuring core systems to ensure technical rigor and seamless integration across all phases. Specifically, we configured Burst AOT compilation (BurstAotSettings_Android.json) to deliver high-performance code generation, a mandatory step for meeting Mobile Compatibility targets. We established crucial parameters within the DynamicsManager.asset for the hovercraft's physics and precise collision detection, and tuned the AudioManager.asset (with a high virtual voice count) and VFXManager.asset to prepare for the dynamic, real-time auditory and visual feedback systems. Finally, the project's structural integrity was locked in by finalizing ProjectVersion.asset, EditorSettings.asset, and UnityConnectSettings.asset, ensuring consistent collaboration and reliable project building using GitHub. This technical finalization allows the team to concentrate fully on the development of the 3D procedural generation engine and the implementation of the complex Boost/Phase-Shift resource management systems.

Project Functionality Summary (Contributor: Ihtishamul Haq & Tirana Mahbub) 

UI Asssets

In this module, we worked on designing and integrating various icon assets for the game’s user interface. Our goal was to create clean and visually appealing PNG icons that matched the game’s futuristic, high-energy theme and maintaining clear and recognizable during gameplay. After completing the designs, we imported the PNG and corresponding meta files into the Unity project and ensured proper configuration for smooth integration within the asset management system. The UIAsset folder contains essential interface elements such as pause, play, close, settings and sound buttons. Each meta file is automatically generated by Unity which stores information like unique IDs and import settings. These help to keep assets properly linked and displayed if they are moved or renamed. The icons and their metadata ensure consistent scaling, quality and organization across menus and scenes which greatly improves the game’s visual clarity, style and overall user experience.




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

