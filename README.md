# ABOUT THE GAME

The game is a “Endless Runner” type.
We control a little white fox who has to collect all the rice on the road, but is constantly attacked by “Onis” (Ogres , in japanese mythology). 

# GAMEPLAY AND MECHANICS

The main characters looks always running forward and is able to avoid attacks by evade them through left and right directions.  Also can jump enemies.
Enemies will be appearing constantly in the opposite direction of the player and will be pushing him/her off the screen (This is when player lose).

The goal of the game is to collect all the “Rice” you can, without lose, until time is up and get
the highest score.

# ART

The art is a simple cartoon-type with strong colors to appeal to young audience.

# MUSIC

The music is based in traditional japanese music with a fast rhythm that invoke a “running” sensation.






# FUNCTIONAL REQUIREMENTS

| Code | Description | Type | Acceptance Criteria |
| ------------- | ------------- | ------------- | ------------- |
| REQ-01 | The game must have a character that follow a road and pickup items.  | Functional  | The character has interaction with other gameobjects and is follow by a camera. |
| REQ-02  | Gameplay duration must be define by a timer. | Functional  | Timer will have a default set, and be modifiable by the user. If the timer runs out , gameplay is over. |
| REQ-03 | Character must be controlled by external device. | Functional  | The character will be controlled through keyboard input. |
| REQ-04 | The game must display player´score label. | Functional | The label will be displayed during the game and at the end of the session.  |
| REQ-05  | The game must have attributes modifiable through a website. | Functional | The attributes will be “Game time”, “Points by item” and “Player speed”.  |
| REQ-06  | The game must have Login and Authentication system. | Functional  | Login and Authentication system will be displayed before start the gameplay and will ask for username and password.  |
| REQ-07  | The game must allow the creation of new users. | Functional  | New users will be created before start the gameplay and will ask for username and password.   |
| REQ-08  | The game must have metrics charts to analize player´s data.  | Functional  | The metrics will be “Average Score”, “Average VS Player Score” and “Player Score” and wil be displayed in the website.  |

# NON-FUNCTIONAL REQUIREMENTS

| Code  | Description | Type  | Acceptance Criteria |
| ------------- | ------------- | ------------- | ------------- |
| REQ-09  | The game must be for PC Platform.  | Non-Functional  | The game will have and executable file for OSX.  |
| REQ-10  | The game must be in 2D/3D.  | Non-Functional  | The game will be in 2D   |
| REQ-11   | The game must be connected to a Database.  | Non-Functional  | The game will be connected to MySQL DB to store player`s data.  |
| REQ-12  | The game must run with a minimum of  Frame Rates.  | Non-Functional  | The game will run with a minimun of 30 FPS.  |
| REQ-13   | The average response time between click and reaction must be quick.  | Non-Functional  | The average response time will be less than 1 second. |
| REQ-14   | The game must be able to run with minimum of RAM. | Non-Functional  | The game will be able to run with 1024 MB of RAM as minimun.  |
| REQ-15  | The code written for the game must be maintainable. | Non-Functional  | The game will be develop in a develop framework and adding documentation.  |

# OTHER REQUIREMENTS

| First Header  | Second Header | Second Header | Second Header |
| ------------- | ------------- | ------------- | ------------- |
| REQ-16  | The gameplay must include obstacles for the player can lose before timeout.  | Functional  | Obstacles will push the player off the screen and make him/her lose.  |
| REQ-17  | The game must include Art, Visual Effects and Music for the environment.  | Functional  | The game will have simple Art, Visual effects and Music according to the game atmosphere.  |
| REQ-18  | The game must allow the player choose between play again or logout after a gameplay ends.  | Functional  | UI will be displayed with the 2 options, so the player will choose.  |
| REQ-19  | The game must be played inside the website.   | Non-Functional  | The game will have a WebGl version that will be available through the website.  |
