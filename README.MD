# 11'Forest


**유료 에셋으로 제작한 프로젝트라 스크립트만 있습니다.**
(Animation, Background, Character)

## Overview
+ 안드로이드 환경
+ 자동으로 진행되는 동물의 숲을 컨셉으로 잡은 방치형 힐링 모바일 게임 기획 (프레젠테이션을 위한 목업 버전)

## Learn more
+ 캐릭터들은 자동으로 움직입니다. (제어 불가능)
+ 카메라는 한 캐릭터만 따라다닙니다. (캐릭터 지정 불가능)
+ 캐릭터 상호작용 애니메이션, 카메라 회전, 카메라 줌 기능을 지원합니다.
+ 모든 캐릭터는 각각 4개의 애니메이션을 가지고 있습니다.
+ 총 5개의 씬이 있습니다.
  + _애니메이션 리스트_
    + 걷기(디폴트 애니메이션, 무한 루프)
    + 넘어지기
    + 춤추기
    + 무언가를 줍는 모션
    + 잠들기
    + 마시기
    + 배가 아픈 모션
  + _씬 리스트_
    + 숲(낮)
    + 숲(밤)
    + 강가(낮)
    + 바다(낮)
    + 길가(낮)

## Scripts
### FPS_Check.cs
+ FPS를 체크합니다 (숲(낮)에만 있습니다.) 


### MyCam.cs
+ 카메라 각도를 조절합니다
  + 각도 제한이 있습니다. 카메라가 갑자기 뒤집어지는 것을 방지하기 위함
+ 카메라 줌 거리를 조절합니다.
+ 하나의 캐릭터만 따라다니도록 카메라 위치를 조절합니다.

### SeaScript, RoadScript, NightScript
+ 이 스크립트들은 해당 씬에서의 캐릭터 애니메이션을 조절합니다.
+ 캐릭터 움직임도 담당합니다. - 캐릭터가 자동으로 움직이게 합니다. (navmesh를 활용했습니다.)
+ 숲(밤)은 움직임이 없는 씬입니다.(No `StartMove()`)
  + 숲(낮), 강(낮), 길가(낮)은 RoadScript를 같이 사용합니다



### UI
+ 씬을 바꾸는 기능을 담당합니다
---
<p align="center">
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/afcf486c-e38c-4f32-8d41-3a8da373a723"
</p>
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/d31599e7-ae2e-46bc-8535-bf4a2ff10721" width="1024" height="512"/>
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/6fb27c2d-b894-4eff-823c-7fbc27503ef3" width="1024" height="512"/>
<img src= "https://github.com/WooChan-Noh/11-forest/assets/103042258/e7b227fc-4098-4cef-8841-fe46fb90515e" width="1024" height="512"/>


