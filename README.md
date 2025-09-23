Real Hotel SIM RPG (Working Title)
A deep-simulation RPG focused on the art, science, and chaos of the hospitality industry. From humble beginnings at a roadside motel to managing a luxury hotel empire, this project aims to simulate the complete career path of a hotelier.

Project Status: Phase 1: Core Foundation (In Progress)

Table of Contents
Project Vision

Core Gameplay Pillars

Getting Started (Developer Onboarding)

Project Standards & Pipeline

High-Level Development Roadmap

Key Systems Overview

Communication Protocol

1. Project Vision
The goal of "Real Hotel SIM RPG" is to create a compelling and realistic simulation of a career in hotel management. The player will experience the full spectrum of the industry, from the granular, moment-to-moment problem-solving of a front desk agent to the high-level strategic decisions of a general manager and owner. We are building a game where player choice, skill development, and strategic thinking have tangible consequences on their career, their finances, and the world around them.

✅ Why: A strong, documented vision prevents feature creep and keeps the team aligned. Every system we build must serve this core fantasy.

2. Core Gameplay Pillars
Our gameplay is built on three interconnected loops:

The Work Loop: The core "job" simulation. This includes checking guests in via the PMS (Property Management System), handling guest requests and complaints through a dynamic dialogue system, and solving problems that arise during a shift.

The Live Loop: The player's life outside of work. This involves managing personal stats (Energy, Stress, Finances), upgrading their apartment, pursuing education or training in the City Hub, and maintaining a work-life balance.

The Dynamic Simulation: The overarching systems that make the world feel alive. This includes the AI Event Director that triggers random events (e.g., power outages, VIP arrivals), a fluctuating Economy that affects hotel pricing and player expenses, and a complex Guest & Coworker AI system that simulates varied personalities and behaviors.

3. Getting Started (Developer Onboarding)
This section outlines the required setup for any developer working on the project.

Prerequisites:
Engine: Unreal Engine 5.3

Source Control (Code): Git client (e.g., GitHub Desktop, SourceTree)

Source Control (Assets): Perforce Visual Client (P4V)

Task Management: Access to our project Trello/Jira board.

Setup Instructions:
Clone the Code Repository:

Bash

git clone [Your-GitHub-Repo-URL-Here]
Configure Perforce:

Connect to the Perforce server at [Your-Perforce-Server-Address:Port].

Create a workspace pointing to the project's root directory.

Get Latest Revision from the depot to sync all large-binary assets (.uasset, .umap, etc.).

Generate Project Files:

Right-click the .uproject file and select "Generate Visual Studio project files."

Open the Project:

Launch the project by opening the .sln file (for C++ development) or the .uproject file (for Blueprint/Editor work).

✅ Why: A standardized setup process eliminates "it works on my machine" issues and ensures every team member is working with the exact same project state.

4. Project Standards & Pipeline
Adherence to these standards is non-negotiable.

Folder Structure
All assets must be placed within the predefined /Content directory structure. Refer to the Project_Organization_Guide.md in the /Docs folder for a full breakdown.

Naming Conventions
All files must be prefixed according to their type for clarity and organization.

Blueprints: BP_PlayerController, BP_GuestAI

Levels/Maps: LVL_Motel01_Graybox, LVL_CityHub

Systems: SYS_Economy, SYS_EventDirector

UI Widgets: WBP_PMS_Main (Widget Blueprint)

Materials: M_Concrete_Polished, MI_Wood_Oak (Master/Instance)

Source Control Workflow
Code (.h, .cpp, .sln, etc.) is committed to GitHub.

Assets (.uasset, .umap, etc.) are submitted to Perforce.

Main branch is for stable, weekly builds ONLY.

All daily work must be done on a feature branch (e.g., Dev_Caleb/PMS_CheckIn, Dev_Gemini/AI_Pathing).

✅ Why: This dual-source-control approach is industry standard for Unreal projects. Git excels at text-based code, while Perforce is built to handle the massive binary files common in game development. This structure prevents repository bloat and corruption.

5. High-Level Development Roadmap
[ ] Phase 1: Core Foundation (Player Controller, UI Framework, Graybox Levels, Basic AI)

[ ] Phase 2: Work Loop (PMS, Dialogue, Check-In, Reputation)

[ ] Phase 3: Live Loop (Player Stats, Apartment Upgrades, City Hub)

[ ] Phase 4: Dynamic Systems (Event Director, Advanced AI, Economy)

[ ] Phase 5: Expansion (Career Promotions, Mid-Tier Hotels, Management Gameplay)

[ ] Phase 6: Endgame (Hotel Ownership, Franchise Mechanics)

6. Key Systems Overview
/Systems/PMS_System: The core software players will interact with. Manages reservations, guest profiles, room status, and billing.

/Systems/EventDirector: A "storyteller" AI that injects dynamic events and challenges into gameplay to ensure no two shifts are the same.

/Systems/Economy: Simulates city-wide economic trends, seasonal demand, and inflation, affecting hotel rates and player costs.

/Systems/AI: A robust system governing the behavior of Guests, Coworkers, and Managers.

✅ Why: Documenting our core systems from day one forces us to think about their dependencies and how they will interact, preventing architectural conflicts down the line.

7. Communication Protocol
Daily Standup: See #dev-log on Discord.

Tasking: Trello/Jira Board.

Bugs: Report all issues via the #bugs channel on Discord and log them in the task tracker.

Design Discussion: #design channel on Discord.
