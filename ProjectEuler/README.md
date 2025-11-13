[![Build & Tests](https://github.com/zhollis21/ProgrammingExercises/actions/workflows/BuildAndTestProjectEuler.yml/badge.svg)](https://github.com/zhollis21/ProgrammingExercises/actions) [![.NET](https://img.shields.io/badge/.NET-10-brightgreen)](https://dotnet.microsoft.com/) [![License](https://img.shields.io/github/license/zhollis21/ProgrammingExercises)](LICENSE)

# Project Euler Solutions

This repository contains a collection of solutions to Project Euler problems implemented in C# using .NET 10. The solutions are organized as a small console application and a unit test project. Each problem's implementation is in the `ProjectEuler` project and is designed to be easy to run and extend.

## Table of Contents

- Overview
- Prerequisites
- Build
- Run
- Tests
- Project structure
- Adding a new solution
- Status
- License

## Overview

Project Euler (https://projecteuler.net) is a set of mathematical and programming problems. This repository contains implementations for a subset of those problems, focusing on clear, testable C# solutions.

## Prerequisites

- .NET 10 SDK (or compatible)
- A C#-aware editor or IDE (Visual Studio, VS Code, Rider, etc.)

Verify your .NET SDK with:

`dotnet --version`

## Build

From the repository root you can build the projects with:

`dotnet build`

Or build a specific project:

`dotnet build ProjectEuler/ProjectEuler.csproj`

## Run

The `ProjectEuler` console application runs interactively and lets you choose which problem to execute.

Run the console app from the repository root with:

`dotnet run --project ProjectEuler/ProjectEuler.csproj`

When the program starts you can:
- Enter `0` to run all available problem solutions
- Enter a problem number to run only that solution

Each problem will print the problem summary and the calculated answer.

## Tests

Unit tests are provided in the `ProjectEuler.Tests` project. Run tests with:

`dotnet test ProjectEuler/ProjectEuler.Tests/ProjectEuler.Tests.csproj`

## Project structure

- `ProjectEuler/` - Console application containing problem implementations and utility helpers
  - `Problems.cs` - Implementations of individual Project Euler problems
  - `Helpers.cs` - Utility helpers and prime number utilities
  - `ProblemSummaries.cs` - Problem descriptions used by the console app
  - `Program.cs` - Program entry point and interactive prompt

- `ProjectEuler.Tests/` - xUnit test project for validating problem outputs

- `.github/workflows/` - CI workflows for build and test (GitHub Actions)

## Adding a new solution

To add a solution for a new Project Euler problem:

1. Add a new method to `ProjectEuler/Problems.cs` with the signature matching the other problems (for example `public static long Problem11()`), include a short Console write of the problem summary and return the computed value.
2. Add the problem description to `ProjectEuler/ProblemSummaries.cs` as a new property (e.g. `Problem11`).
3. Register the problem in `ProjectEuler/Helpers.cs` by adding a new entry to the `_problemMap` dictionary, mapping the problem number to the corresponding `Problems.ProblemXX` method.
4. Add or update unit tests in the `ProjectEuler.Tests` project to assert the expected result.

## Status

This repository currently contains solutions for problems 1–10. The repository owner maintains and may add additional solutions over time. External contributions are not accepted.

## License

This repository includes a `LICENSE` file at the project root that describes the project's license. See that file for the exact terms.
