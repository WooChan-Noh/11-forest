# 11'Forest


*Only upload scripts that contain paid assets.*
(Animation, Background, Character)

## Overview
+ Android Build
+ Mok-up Application (using Presentation)
+ Characters move automatically (can't user control)
+ Camera locked on one character (can't change)
+ User can control character animation, camera rotation, camera zoom
+ All character have four animation, this app has five Scene
  + _Animaion List_
    + Walk(Default, Loop)
    + Falling down
    + Dance
    + Pick up motion
    + Sleep
    + Drink
    + Sick motion
  + _Scene List_
    + Forest(Day)
    + Forest(Night)
    + River(Day)
    + Sea(Day)
    + Roadside(Day)

## Scripts
### FPS_Check
+ Check FPS (it works only Scene1) 


### MyCam
+ Use one finger to change rotaion.
  + have a rotation angle limit : prevent camera jumping
+ Use two finger to change zoom 
+ Control camera position (follow locked character)


### SeaScript, RoadScript, NightScript
+ This scripts control character animaion
+ and control auto moving(use navemesh and move point-_RANDOM_)
+ Only Forst(Night) is a non-moving scene (No *StartMove()*)
  + RoadScript : Forest(Day), River(Day), Roadside(Day)
  + SeaScript : Sea(Day)
  + NightScript : Forest(Day)


### UI
+ Using change scene
