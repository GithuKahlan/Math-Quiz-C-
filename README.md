# Math Quiz Game (C# Windows Forms)

## Overview

Math Quiz Game is a Windows Forms application developed in C#. The project allows users to practice arithmetic operations through a configurable quiz system.

Users can choose the number of rounds, operation type, and difficulty level before starting the quiz. The application then generates random questions and tracks the user's performance throughout the game.

---

## Features

- Select the number of quiz rounds
- Choose operation type:
  - Addition
  - Subtraction
  - Multiplication
  - Division
  - Mixed Operations
- Choose difficulty level:
  - Easy
  - Medium
  - Hard
  - Mixed Difficulty
- Countdown timer for each question
- Automatic score tracking
- Summary screen showing:
  - Total rounds
  - Correct answers
  - Wrong answers
  - Pass/Fail result
- Restart quiz functionality
- Exit application functionality

---

## Project Structure

### GameEngine

Handles the core game logic, including:

- Starting a new game
- Generating random numbers
- Generating questions
- Calculating correct answers
- Checking user answers
- Tracking scores and rounds

### Question

Represents a quiz question and stores:

- First number
- Second number
- Operation type
- Correct answer

### Forms

#### Main Form

Allows the user to configure the game settings.

#### Quiz Form

Displays questions, timer, and answer input.

#### Summary Form

Displays the final quiz results.

---

## Technologies Used

- C#
- .NET Windows Forms
- Object-Oriented Programming (OOP)

---

## Concepts Practiced

- Classes and Objects
- Properties
- Enumerations (Enums)
- Event-Driven Programming
- Windows Forms Development
- Separation of UI and Business Logic
- State Management
- Basic Software Architecture

---

## Future Improvements

- High score system
- Save results to file or database
- Multiple-choice questions
- Difficulty-based timers
- Improved UI design
- Sound effects and animations
- Unit testing for GameEngine


Kahlan Sultan Al-Awzari
Software Engineering Student
