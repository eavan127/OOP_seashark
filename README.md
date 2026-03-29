# OOP_seashark
---
## 👥 Group Members
1. Eavan Tan – 24006152  
2. Nur Amalia Izzati – 24005350  
3. Chua Xin Ying – 24006979  
4. Tuan Nur Afifah Khaira Zulfa Binti Tuan Zaki – 24006290  
5. Farhana Binti Yakmin Zada – 24006288  
6. Jessy Pang Xin Yuan – 24006291  
---
## 📌 **Overview**

**Sea Shark Game** is an interactive educational game designed to teach C# programming concepts through a gamified undersea platformer. Players control a shark avatar, navigating multi-tiered underwater levels, collecting keys, avoiding obstacles, and answering C# quizzes with immediate feedback and hints. The project demonstrates how Object-Oriented Programming (OOP) can be applied in a practical and engaging scenario.

The game combines learning and gameplay, ensuring that players can practice programming concepts in an interactive and progressive manner.

**🎮 Game Preview:**

![Gameplay Preview](;;;.png)
---

## 🎯 Objectives
This project applies and demonstrates the following OOP concepts:

| Concept | Description |
|---------|-------------|
| **Encapsulation** | Protects sensitive data like score, keys, position, and quiz answers |
| **Abstraction** | Simplifies level and quiz management using abstract classes |
| **Inheritance** | Levels share common behaviors but can have unique features |
| **Polymorphism** | Uniform methods behave differently depending on the object instance |

---

---

## 🛠 Features
| Feature | Description |
|---------|-------------|
| Multi-tiered Levels | Beginner and Advanced stages with increasing difficulty |
| Quiz Pop-ups | Multiple-choice C# questions appear during gameplay |
| Hint System | Provides guidance for quizzes if players are stuck |
| Score & Key Tracking | Tracks player score and keys collected |
| Timer System | Level-based countdown for challenge |
| HUD Interface | Displays score, keys, timer, and level info |
| Win/Lose Feedback | Displays success or fail screen at level completion |
---

## 💻 **Technologies Used**

- **Language:** C#  
- **Concepts:** Encapsulation, Inheritance, Polymorphism, Abstraction  
- **IDE:** Visual Studio Code  
- **Version Control:** GitHub  

---

## ⚙️ How to Run the Program
1. Open the solution file `OOP_SEASHARK.slnx` in Visual Studio.  
2. Build the project.  
3. Run using **Start Debugging (F5)**.  

---


## 📁 Project Structure

<details>
<summary>Click to expand Project Files</summary>
OOP_SEASHARK.slnx / OOP_SEASHARK.sln     # Solution files
Program.cs                              # Main program entry
GameManager.cs                           # Controls overall game logic
GameState.cs                             # Manages game states (Start, Playing, Completed)
Player.cs                                 # Player class handling movement and stats
Level.cs                                  # Base class for all levels
BeginnerLevel.cs / AdvancedLevel.cs      # Level implementations
BeginnerQuiz.cs / AdvancedQuiz.cs        # Quiz handling for each level
frmQuizPopup.cs                           # Pop-up quiz interface
Hint.cs                                   # Quiz hint interface
SelectLevel.cs                            # Level selection screen
TimeUp.cs                                 # Time-up notification screen
Main.cs                                   # Main game form
OutlineLabel.cs                           # Custom label for UI
Resources/                                # Images and assets
    shark.png
    shark2.png
    background.jpg
    background sea.png
    key.png
    door.png
    coral.png
    sea star.png
    ... (other images)
music/
    background.mp3                        # Background music
Properties/
    AssemblyInfo.cs                        # Project metadata
    Resources.Designer.cs                  # Resources class
    Settings.Designer.cs                   # Settings configuration
OOP_GroupProject.csproj                   # Project configuration
build_err.txt / build_err_utf8.txt        # Build error logs
---

## 🚀 **How to Play**

1. Launch the game to reach the Home screen.  
2. Select a level to start the game.  
3. Control the shark avatar to navigate platforms, collect keys, and avoid obstacles.  
4. Answer quizzes when they appear; use the Hint button if needed.  
5. Complete all quizzes within the time limit to unlock the next level.  
6. Reach the final goal in Advanced Level to win the game.  

---

## 💡 **Possible Improvements**

- Add more levels and varied obstacles for extended gameplay  
- Implement more difficulty level and obstacles based on player performance  
- Add more interactive quiz types and visual feedback  
- Include multiplayer modes  

---

## 📝 **License**

This project was developed as part of an educational C# OOP course for learning purposes.

