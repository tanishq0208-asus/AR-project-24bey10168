# ✈️ B-2 Spirit Stealth Bomber AR Experience

![Unity](https://img.shields.io/badge/Unity-6000.0.5f1-blue.svg)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20ARCore-brightgreen.svg)
![Render Pipeline](https://img.shields.io/badge/Pipeline-URP-orange.svg)
![License](https://img.shields.io/badge/License-MIT-lightgrey.svg)

An interactive Augmented Reality (AR) and 3D simulation built with **Unity** and **AR Foundation**. This project allows users to spawn and pilot a low-poly B-2 Spirit Stealth Bomber in real-world environments using plane detection and a custom virtual joystick interface.

---

## 🌟 Key Features

* **Real-World Surface Detection:** Uses ARCore raycasting and plane tracking to detect horizontal surfaces for accurate 3D model placement.
* **Touch Flight Controls:** On-screen virtual joystick providing smooth direction, rotation, and forward translation.
* **Optimized Mobile Performance:** Built on Unity's Universal Render Pipeline (URP) with targeted graphics API settings for smooth FPS on mobile hardware.
* **Dynamic Camera Tracking:** Camera-relative movement vectors ensuring intuitive controls regardless of user viewing angle.
* **Presentation-Ready:** Native support for zero-latency screen mirroring to laptops via `scrcpy`.

---

## 🛠️ Tech Stack & Requirements

| Component | Specification |
| :--- | :--- |
| **Engine** | Unity 2022.3 LTS / Unity 6+ |
| **Render Pipeline** | Universal Render Pipeline (URP) |
| **AR Framework** | AR Foundation + Google ARCore XR Plugin |
| **Target Platform** | Android 7.0 (Nougat, API Level 24) or higher |
| **Architecture** | ARM64 (IL2CPP) |
| **Graphics API** | OpenGL ES 3.0 |

---

## 📁 Repository Structure

```text
├── Assets/
│   ├── PolyOne/             # 3D Mesh Assets & FBX Models (B-2 Bomber)
│   ├── Joystick Pack/        # Virtual UI Joystick Components
│   ├── Prefabs/             # Scaled & Configured AR Prefabs
│   ├── Scripts/             # Core C# Logic
│   │   ├── ARPlacementManager.cs   # AR Raycasting & Object Spawning
│   │   ├── VirtualJoystick.cs      # Canvas Pointer Tracking & Input Vector
│   │   └── AircraftController.cs   # Movement Physics & Orientation Logic
│   └── Scenes/              # Main AR Sample Scene
├── ProjectSettings/          # Unity Project & XR Plugin Configurations
└── README.md
