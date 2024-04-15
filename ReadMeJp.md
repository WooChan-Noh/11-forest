# 11'Forest

有料アセットで制作したプロジェクトなので、**スクリプトのみ**です。(Animation, Background, Character)

## Overview
+ アンドロイドビルド
+ **自動で進行する動物の森**をコンセプトにした放置型ヒーリングモバイルゲームの企画(プレゼンテーション用モックアップ版)

## Learn more
+ キャラクターは自動的に動きます。 (制御不可)
+ カメラは一人のキャラクターだけを追いかけます。 (キャラクター指定不可)
+ キャラクターインタラクションアニメーション、カメラ回転、カメラズーム機能があります。
+ すべてのキャラクターはそれぞれ4つのアニメーションを持っています。
+ 合計5つのシーンがあります。
  + _アニメーションリスト_
    + 歩く(デフォルトアニメーション、無限ループ)
    + 転倒する
    + 踊る
    + 何かを拾うモーション
    + 眠り
    + 飲み物を飲む
    + お腹が痛いモーション
  + _シーンリスト_
    + 森(昼間)
    + 森(夜)
    + 川(昼間)
    + 海(昼間)
    + 大道(昼間)
   
## Scripts
### FPS_Check.cs
+ FPSをチェックします(森(昼間)のみにあります)


### MyCam.cs
+ カメラの角度を調整します
  + 角度制限があります。カメラが突然ひっくり返るのを防ぐためです。
+ カメラのズーム距離を調整します。
+ 一人のキャラクターだけを追いかけるようにカメラの位置を調整します。
  
### SeaScript, RoadScript, NightScript
+ これらのスクリプトは、そのシーンでのキャラクターのアニメーションを調整します。
+ キャラクターの動きも担当します。
  + キャラクターが自動的に動くようにします(navmeshを活用しました)。
+ 森(夜)は動きのないシーンです(No StartMove())。
  + 森(昼)、川(昼)、道端(昼)はRoadScriptを使います。


### UI
+ シーンを切り替える機能を担当します。
---
<p align="center">
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/afcf486c-e38c-4f32-8d41-3a8da373a723"
</p>
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/d31599e7-ae2e-46bc-8535-bf4a2ff10721" width="1024" height="512"/>
<img src="https://github.com/WooChan-Noh/11-forest/assets/103042258/6fb27c2d-b894-4eff-823c-7fbc27503ef3" width="1024" height="512"/>
<img src= "https://github.com/WooChan-Noh/11-forest/assets/103042258/e7b227fc-4098-4cef-8841-fe46fb90515e" width="1024" height="512"/>


