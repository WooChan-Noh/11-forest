# 11'Forest


**Upload scripts only (This project contain paid assets.)**
(Animation, Background, Character)

## Overview
+ Android build
+ Mok-up application (for Presentation)
## Learn more
+ Characters move automatically (can't user control)
+ Camera following only one character (can't change)
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
### FPS_Check.cs
+ Check FPS (it works only Forest(Day)) 


### MyCam.cs
+ Use one finger to change rotaion.
  + have a rotation limit : prevent camera jumping
+ Use two finger to change zoom 
+ This Script control camera position (follow only one character)


### SeaScript, RoadScript, NightScript
+ This scripts control character animation
+ and control character movement : characters move automatically (use navemesh and _RANDOM_ move point)
+ Only Forst(Night) is a non-moving scene (No `StartMove()`)
  + RoadScript used this scenes : Forest(Day), River(Day), Roadside(Day)
  + SeaScript : Sea(Day)
  + NightScript : Forest(Night)


### UI
+ Using change scene
---
<p align="center">
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/afcf486c-e38c-4f32-8d41-3a8da373a723"
</p>
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/d31599e7-ae2e-46bc-8535-bf4a2ff10721" width="1024" height="512"/>
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/6fb27c2d-b894-4eff-823c-7fbc27503ef3" width="1024" height="512"/>
<img src= "https://github.com/WooChan-Noh/11-forest/assets/103042258/e7b227fc-4098-4cef-8841-fe46fb90515e" width="1024" height="512"/>


