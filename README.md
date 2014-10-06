Arcade-Shooter-
===============

This repository contains the basic beginning structure of an arcade shooter game.  I have added files corresponding
to every script that I've written, but the game is powered by the Unity engine.  These scripts are attached to actors
within the game world in order to create a working game.

*** The bulk of the code can be found in player.cs, bullet1.cs, enemy1.cs, and sceneManager.cs

1) Description
This game is a typical arcade shooter similar to Geometry Wars or Asteroids.
The goal of the game is to survive for as long as possible and get a high
score.  Currently the game is VERY EASY.

2) How to play
The game opens to a menu with a button that must be clicked in order to 
play.  Once that button is clicked, the game begins.  To move, use
WASD and to shoot, simply left mouse click and a bullet will shoot in
the direction of the mouse relative to the player ship.  Shoot the enemy
ships and avoid being hit by them.  The longer you survive, the higher 
your score multiplier will go, increasing the rate at which you raise
your score.  Upon dying, there will be a menu that offers to either play
again or quit the game.

3) Who built what
I used free assets from the Unity store for the player and 
enemy ships as well as the lens flares that can be found throughout the
game.  Everything else was made with Unity primatives.

4) Assets
Player ship: https://www.assetstore.unity3d.com/#/content/1807
Enemy ship: https://www.assetstore.unity3d.com/#/content/3549
Lens flares: https://www.assetstore.unity3d.com/#/content/5

5) Next steps
There is still a good amount of work to be done before I would be 
satisfied with this game.  I want to add different weapon types that the
player can earn to use for a certain amount of time.  I also want to add
more enemy variants that will behave in different ways with different
"personalities."  I would also like to fix the spawning patterns as well
as create an algorithm that will increase the difficulty of the game as
the player score gets higher.
