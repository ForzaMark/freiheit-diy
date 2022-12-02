# Freiheit-DIY :tv:

Ein VR-Spiel zu Amatuerelektronik, Zäsur und Informationsfreiheit in der DDR.

Das Spiel wurde entwickelt von Anna Rauscher, Margret Schild und [Mark Heimer](me.cratory.de) in Kooperation mit [Coding da Vinci](https://codingdavinci.de/) und dem [Zuse Computer Museum Hoyerswerda](https://zuse-computer-museum.com/)

## :white_check_mark: Vorraussetzungen
- Unity 2020.3.31f1

## :rocket: Getting Started
- Klone das Repository 
- Importieren der Assets
  - Um das Spiel lokal korrekt entwickeln zu können benötigst du folgende Assets die du aus dem Unity-Asset-Store kostenfrei herunterladen kannst
    - Old television PBR free (https://assetstore.unity.com/packages/3d/props/electronics/old-television-pbr-free-101886)
    - Free Rug pack (https://assetstore.unity.com/packages/3d/props/interior/free-rug-pack-118178)
    - Interior Props Pack (https://assetstore.unity.com/packages/3d/props/interior/interior-props-pack-asset-86452)
    - Apartment Door (https://assetstore.unity.com/packages/3d/props/apartment-door-146225)
    - XR Interaction Toolkit & XR Plugin Management
      - Diese Assets sind bereits in Unity integriert. Um sie zu aktivieren gehe zu Windows -> Package Manager -> Wähle Packages: Unity Registry -> Suche nach "XR Interaction Toolkit" und "XR Plugin Management" -> importiere beide Packages
      - In "XR Interaction Toolkit" muss noch der Device Simulator aktiviert werden. Wähle dazu das Package "XR Interaction Toolkit" aus, erweitere den Tab "Samples" und importiere "XR Device Simulator"
    - füge ggf. noch Texturen für die Wände und den Boden hinzu. Die Texturen für Wände und Boden können nicht in dem Repository bereitgestellt werden, da die Veröffentlicher nicht erlauben die Dateien unter einer Open-Source-Lizenz zu veröffentlichen. Die Textur für die Wände kann unter https://www.textures.com/download/WallpaperForties0002/18820 und die Textur für den Boden unter https://www.textures.com/download/PBR0826/139428 heruntergeladen werden.
- Das Spiel sollte jetzt ausführbar sein. Gegebenenfalls fehlen dir noch Inputs wie das "Successvideo" und das "Credit Video". Diese musst du händisch selbst importieren.
- Hilf dabei das Spiel weiterzuentwickeln (Offene Issues findest du auf [Trello](https://trello.com/b/9MdesXd9/entwicklung)) 

## :computer: Verschieden environments
- Das Spiel kann in verschiedenen Environments gestartet werden
- Wähle deine bevorzugte Environment unter ConverterConstructionRoom -> GameSystem -> Environment
- <img width="1279" alt="image" src="https://user-images.githubusercontent.com/28750031/197191844-775fdcfb-4b2b-477e-91ce-8dd03a875a39.png">

  - Wenn du die Anwendung ohne ein reales VR Headset testen möchtest wähle "Local Development with Mock Headset"
  - Wenn du die Anwendung mit einem verbunden VR Headset testen möchtest wähle "Local Development with VR Headset"
  - Wenn du einen Production-Build für ein VR Headset erstellen willst wähle "Production" 
    - Die Anwendung ist hauptsächlich für die Quest 2 entwickelt. Das Projekt sollte aber auch auf anderen Brillen funktionieren. Dafür müssen ggf. die Build-Settings angepasst werden   


## :speaker: Sounds
- Transkriptionen aller eingesprochenen Sounds sind unter https://github.com/ForzaMark/freiheit-diy/tree/main/Assets/Sounds zu finden
- Die Reihenfolge in welcher die Sounds im Spiel abgespielt werden ist:
  - IntroductionStory
  - MoveAndTargetTestObject
  - GrabAndMoveTestObject
  - FinishGameControlExplanation
  - PlayerArrivedAtTable
  - PlayerPlacedTransistorCorrectly

## :gem: Credits
#### 3d-Modelle
- Schuhschrank: 
	- https://sketchfab.com/wang2dog - Lizenz: CC Attribution
- Couch: 
	- https://sketchfab.com/R3indeer - Lizenz: CC Attribution-NonCommercial
- Schuhe: 
	- https://sketchfab.com/WirtualneMuzeaMalopolski - Lizenz: CC0 Public Domain
      - https://sketchfab.com/spogna - Lizenz: CC Attribution-NonCommercial
      - https://sketchfab.com/adresen - Lizenz: CC Attribution
- Fliesentisch: 
	- https://sketchfab.com/WunderWurst - Lizenz: CC Attribution
- Lampen: 
	- https://sketchfab.com/tijerin_art - Lizenz: CC Attribution
      - https://sketchfab.com/rigart - Lizenz: CC Attribution
- Bilderrahmen: 
	- https://sketchfab.com/ShreyasGarje - Lizenz: CC Attribution
- Fernbedienungn:
	- https://sketchfab.com/pcosfaj - Lizenz: CC Attribution

#### Bilder
- Bild Berlin: https://codingdavinci.de/daten/berliner-stadtansichten
- Natur Bild: https://unsplash.com/@birminghammuseumstrust

### Videos
- Stock footage provided by Videvo, downloaded from videvo.net


#### Texturen
- Die Texturen für Wände und Boden sind von https://www.textures.com/support/faq-license. Ihre Texturen können nicht unter Open-Source-Lizenz veröffentlicht werden. Deshalb haben die Wände und der Boden keine Textur die aber beliebig wieder hinzugefügt werden kann.
