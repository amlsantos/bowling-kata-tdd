![build](https://github.com/amlsantos/bowling-kata-tdd/actions/workflows/build.yml/badge.svg)
![test](https://github.com/amlsantos/bowling-kata-tdd/actions/workflows/test.yml/badge.svg)

# Bowling TDD Kata

## Introduction

The Bowling Game Kata is a classic exercise used to practice test-driven development (TDD) and improve understanding of the rules and scoring mechanics of bowling. 
The goal is to create a class that can calculate the score of a bowling game based on a series of rolls.

## Project Highlights

- **TDD (Test-Driven Development)**: The development process follows TDD principles, ensuring that tests are written before the corresponding code.

## Getting Started

### Prerequisites

Make sure you have the following installed on your machine:

- [.NET](https://dotnet.microsoft.com/download)

### Clone the Repository

```bash
git clone https://github.com/amlsantos/bowling-kata-tdd.git
cd bowling-kata-tdd
```

### Build and Run Tests
```bash
dotnet build
dotnet test
```

## Kata Requirements

- A game consists of 10 frames.
- In each frame, the player has two opportunities to knock down 10 pins with a ball.
- The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.
- A spare is when the player knocks down all 10 pins in two rolls. The bonus for that frame is the number of pins knocked down by the next roll.
- A strike is when the player knocks down all 10 pins with the first roll in a frame. The bonus is the value of the next two rolls.
- In the tenth frame, a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame. However, no more than three balls can be rolled in the tenth frame.

# Expression tree Kata - Project Structure

This section provides an overview of the project structure for the Expression tree Kata.

## Directory Structure

```plaintext
bowling-kata-tdd/
|-- src/
|   |-- Domain/
|       |-- Frame.cs
|       |-- Game.cs
|       |-- Roll.cs
|   |-- UI/
|       |-- Program.cs
|-- tests/
|   |-- UnitTests/
|       |-- GameTests.cs
|-- .gitignore
|-- Bowling.sln
|-- README.md
```
