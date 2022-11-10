Overview of the Game

The idea of the game was to make a game akin to ‘Find Waldo’ or other games where the player needs to pick the odd one out of a crowd. In this project, the player moves a character in a 3D space from a 3rd person view by using keyboard controls as well as the mouse position for looking around. The goal of the game is to find the cylinder shaped figure among the capsule shaped figures, then press the key E by the cylinder before time runs out to gather points. Each time the player finds the cylinder within the time frame, they gain one point and the level resets with new positions, so the player wants to gather as many points as they can before they miss the time limit and get a Game Over screen.

Main Parts of the Game:

Player - A character moved with the keyboard WASD or arrow keys and space.
Camera - Following and looking at the character. Moving the mouse also changes the camera view.
Cylinder (target) - Spawns once per game/level. Each time the player interacts with the cylinder, the player gains one point.
Capsules (obstacles) - Spaws a random amount in random positions. They have mass to make it more difficult for the player to navigate around, and are otherwise present to distract the player from the goal they want to achieve.
Play field - A restricted area for the player to move around in and for the other game objects to spawn.
Time - The timer counts down from 10 seconds. If you complete the level within the time limit, you gain a point, otherwise, game over.

Game Features:

The positions of both the capsules and the cylinder are randomly selected each level to help with replayability.
The countdown timer creates a sense of urgency in reaching the goal.
The colors and shapes are similar to add to the challenge.
The game keeps track of points.

Project Parts

Scripts:

CollideScript - used for checking collision between the player and target, checking for E keypress, adding points, and reloading the scene.
DontDestroyScript - used for carrying over points between scenes.
GameManagerScript - used for the game over screen and resetting points.
MainMenuScript - used for loading different scenes and quitting the game.
MovementScript - used for moving the character through a character controller.
PointScript - used for containing the functions of adding points and displaying them on the UI.
SpawnScript - used for spawning the capsule game objects randomly and through raycasting within the play field.
TargetSpawnScript - used for spawning the target randomly once.
TimerScript - used for counting down time and displaying it on the UI, then shifting to game over if the timer runs out.

Models and Prefabs:

Player made with capsule and sphere game objects directly from unity
Capsules and cylinder made from unity capsule and cylinder game objects respectively.
Play field build with ProBuilder.

Materials:

Simple skin and body color material on the player.

Scenes:

Gameplay scene containing the actual game and the game over screen.
Menu scene containing the main menu and how to play description.

Testing:

Game was tested on a Windows computer.
