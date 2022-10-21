# Freiheit-DIY :tv:

Ein VR-Spiel zu Amatuerelektronik, Zäsur und Informationsfreiheit in der DDR.

Das Spiel wurde entwickelt von Anna Rauscher, Margret Schild und [Mark Heimer](me.cratory.de) in Kooperation mit [Coding da Vinci](https://codingdavinci.de/) und dem [Zuse Computer Museum Hoyerswerda](https://zuse-computer-museum.com/)

## :white_check_mark: Prerequisite
- Unity 2020.3.31f1

## :rocket: Getting Started
- Klone das Repository 
- Installiere die Dependencies? 
- Setup successvideo etc. 
- Run on your machine
- Feel free to contribute (you can find open issues on [Trello](https://trello.com/b/9MdesXd9/entwicklung)) 

## :computer: Local Development
- The game supports multiple environments
- Select the appropriate environment in the inspector under ConverterConstructionRoom -> GameSystem -> Environment
- <img width="1279" alt="image" src="https://user-images.githubusercontent.com/28750031/197191844-775fdcfb-4b2b-477e-91ce-8dd03a875a39.png">

  - If you want to test the application without a VR Headset use "Local Development with Mock Headset"
  - If you want to test the application with a connected VR Headset use "Local Development with VR Headset"
  - If you want to test a production build of the application on a connected VR Headset use "Production" 
    - The application usually targets the Quest 2. For other VR Headsets you probably need to tweak the Project and Build Settings   


## :speaker: Sounds
- You can find a transcription of all sounds under https://github.com/ForzaMark/freiheit-diy/tree/main/Assets/Sounds
- The order in which the sounds are played in the game is:
  - IntroductionStory
  - MoveAndTargetTestObject
  - GrabAndMoveTestObject
  - FinishGameControlExplanation
  - PlayerArrivedAtTable
  - PlayerPlacedTransistorCorrectly
