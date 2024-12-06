# 🐚 Overflow 🌊

Welcome to the **Overflow**, a fun and engaging 2D Unity game where you control a seahorse on an epic mission! Shoot spikes to fend off crabs, rescue other seahorses, and achieve the highest score. 🦐🦀

---

## ✨ Features

- 🎮 **Player-Controlled Seahorse**: Glide through water as a nimble seahorse
- 🏹 **Shoot Spikes**: Defend yourself from enemy crabs with spike projectiles
- 🤝 **Rescue Seahorses**: Capture other seahorses to increase your score and allies
- 🌟 **Enemy AI**: Crabs chase you and try to block your progress
- 🌊 **Water Physics**: Smooth, fluid-like controls for immersive gameplay
- 📈 **Scoring System**: Earn points for each seahorse captured and crab defeated
- 💻 **Beginner-Friendly Code**: Built with Unity and C#, perfect for learning game development basics

---

## 🛠️ Installation

### Method 1: Play in Unity Editor

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/Overflow.git
   cd Overflow
   ```

2. Open Unity Hub and select Open Project

3. Navigate to the cloned directory and open the project

4. Press the Play button in Unity Editor to start the game

### Method 2: Export and Play
---

## 🎮 Controls

1. Move: Use the arrow keys to navigate

2. Shoot: Press the Space key to fire spikes

3. Capture Seahorses: Swim close to other seahorses to rescue them

- Click the "Delete" button, and the task disappears from the list

---

## 📂 File Structure

```
Overflow/
├── Assets/                               # Contains all game assets used in the project
│   ├── Audios/                           # Stores sound effects
│   │   ├── character_movement.wav        # Audio for seahorse movement
│   │   ├── seahorse_collect.wav          # Audio for rescuing another seahorse
│   │   ├── shooting_sfx.wav              # Sound effect for shooting spikes
│   ├── BayatGames/                       # Clean this up please 😭 🧹
│   ├── Casual Game Sounds U6/            # Clean this up please 😭 🧹
│   ├── Materials/                        # Stores physical and material properties for objects
│   │   ├── No Friction.physicsMaterial2D # A physics material for objects with no friction
│   ├── Prefabs/                          # Contains reusable game object templates
│   │   ├── Projectile.prefab             # Spike images
│   ├── Scenes/                           # Stores all scenes for the game
│   │   ├── SampleScene.unity             # The main scene where the game is set
│   ├── Scripts/                          # Contains all C# scripts for game logic
│   │   ├── CameraMovement.cs             # Handles camera following the player
│   │   ├── CollectCoin.cs                # Manages collecting seahorses and coins
│   │   ├── EnemyBehavior.cs              # Defines the behavior for enemy crabs.
│   │   ├── FlipEnemy.cs                  # Script to flip enemies based on their direction
│   │   ├── GameManager.cs                # Central script for managing game states and logic
│   │   ├── PlayerMovement.cs             # Controls the movement of the player (seahorse)
│   │   ├── PreformSpikes.cs              # Manages the shooting mechanics for spikes pew pew
│   │   ├── Projectile.cs                 # Handles the behavior of spikes
│   ├── Sprites/                          # Stores 2D images mah goofy seahorse :P
│   │   ├── blue_seahorse.psd             # Player seahorse (he's blue)
│   │   ├── blue_seahorse.psd.meta        # Player seahorse metadata
│   │   ├── crab.psd                      # Player seahorse metadata
│   │   ├── crab.psd.meta                 # Player seahorse metadata
│   │   ├── image 16.png                  # Coin - rename 🧹
│   │   ├── image 16.png.meta             # Coin metadata 
│   │   ├── image 17.png                  # Waves ("ground" of game) - rename 🧹
│   │   ├── image 17.png.meta             # Waves metadata
│   │   ├── pink_seahorse.psd             # Collectable seahorses
│   │   ├── pink_seahorse.psd.meta        # Collectable seahorse metadata
├── Packages/                             # Unity-generated folder for managing dependencies
│   ├── manifest.json                     # Lists all packages required for the project
│   ├── packages-lock.json                # Locks package versions to ensure consistency
├── ProjectSettings/                      # Unity-generated folder for project-wide settings
│   ├── .gitattributes                    # Explains its role in defining Git behavior such as line endings and file handling
│   ├── .DS_Store                         # Describes it as a macOS system file (ignored in version control typically)
│   ├── .gitignore                        # Lists files and folders to ignore in version control
│   ├── LICENSE                           # The license for the project (e.g., MIT, GPL)
│   ├── README.md                         # Documentation about the project


```
* 🧹 — Needs cleanup
* 🐉 — Serious mess (Here be dragons)

---

## 🌟 Future Enhancements

1. Goal is to make it like this: https://www.youtube.com/watch?si=1760XwRBdMYcQzCE&v=oX1hStDDyIo&feature=youtu.be

2. Publish game on itch.io as an indie game


---

## 🤔 Why?

This project is a great starting point for:
- Learning Unity game development
- Practicing C# programming
- Creating fun, portfolio-worthy projects

---

## 📜 License

This project is open-source and available under the MIT License

---

## 🐾 Contributing

Want to add more features? Feel free to submit a pull request with your own inspired features!

---

## ⚠️ Disclaimer

This game is for educational purposes and a fun way to explore game development. Dive into Unity, experiment, and enjoy creating!
