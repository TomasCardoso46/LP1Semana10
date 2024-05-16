# PlayerManagerMVC

## Overview

This project is a simple implementation of a Player Manager application using the Model-View-Controller (MVC) architecture in C#.

## UML Class Diagram

```mermaid
classDiagram
    class Player {
        <<Data>>
        - Name: string
        - Score: int
        + Player(name: string, score: int)
        + CompareTo(other: Player): int
    }

    class CompareByName {
        <<Service>>
        - ascending: bool
        + Compare(x: Player, y: Player): int
    }

    class PlayerController {
        <<Controller>>
        - players: List<Player>
        + PlayerController()
        + InsertPlayer(name: string, score: int): void
        + GetAllPlayers(): List<Player>
        + GetPlayersWithScoreGreaterThan(minScore: int): List<Player>
        + GetPlayersSortedByName(ascending: bool): List<Player>
    }

    class Program {
        <<View>>
        - playerController: PlayerController
        + Main(args: string[]): void
        + InsertPlayer(playerController: PlayerController): void
        + ListAllPlayers(playerController: PlayerController): void
        + ListPlayersWithScoreGreaterThan(playerController: PlayerController): void
        + ListPlayersByName(playerController: PlayerController, ascending: bool): void
    }

    Player "1" --> "*" PlayerController
    PlayerController "1" --> "*" Player
    CompareByName "1" --> "*" Player
    Program "1" --> "1" PlayerController
