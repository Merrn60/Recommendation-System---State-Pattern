# Recommendation System - State Pattern

This repository contains a C# implementation of the **State Pattern** for a Recommendation System that suggests books or movies based on user-selected genres and whether it is New Year. The system uses the State design pattern to manage different recommendation behaviors dynamically.

## Table of Contents
- [Overview](#overview)
- [State Pattern](#state-pattern)
- [How to Run](#how-to-run)
- [License](#license)

## Overview
This project demonstrates the **State Pattern** to provide recommendations for books or movies. The system allows users to choose between book or movie recommendations, select a genre (romantic, action, or horror), and indicate whether it is New Year to receive special recommendations. The State pattern is used to encapsulate recommendation behaviors and transition between states (e.g., book recommendations, movie recommendations, or New Year recommendations).

### Key Components
- **RecommendationContext.cs**: The context class that holds the current state and properties like `Genre` and `IsNewYear`.
- **IRecommendationState.cs**: The interface defining the `Recommend` method for all states.
- **BookRecommendationState.cs**: Handles book recommendation logic, transitioning to genre-specific book states.
- **MovieRecommendationState.cs**: Handles movie recommendation logic, transitioning to genre-specific movie states.
- **NewYearRecomendState.cs**: Provides special New Year recommendations for both books and movies.
- **Book_Types/**: Contains genre-specific book recommendation states:
  - `RomanticBookRecomendState.cs`
  - `ActionBookRecomendState.cs`
  - `HorrorBookRecomendState.cs`
- **Movie_Types/**: Contains genre-specific movie recommendation states:
  - `RomanticMovieRecomendState.cs`
  - `ActionMovieRecomendState.cs`
  - `HorrorMovieRecomendState.cs`
- **Program.cs**: The main program that interacts with the user to set the context and trigger途中

System: trigger recommendations.

## State Pattern
The State pattern allows the `RecommendationContext` object to change its behavior based on its internal state. In this system, the state determines the type of recommendations provided (e.g., book or movie recommendations for specific genres, or special New Year recommendations). Each state (`BookRecommendationState`, `MovieRecommendationState`, `NewYearRecomendState`, or genre-specific states) implements the `IRecommendationState` interface, defining how recommendations are made.

## How to Run
1. **Prerequisites**:
   - Install the .NET SDK (version 6.0 or later recommended).
   - A C# IDE like Visual Studio or Visual Studio Code.

2. **Steps**:
   - Clone this repository:
     ```bash
     git clone https://github.com/your-username/RecommendationSystem.git
