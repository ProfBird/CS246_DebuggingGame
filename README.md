# Example of the Factory Method Design Pattern
A C# console app using .NET 6.0.

## Project 1: Debugging Game
This project is only "inspired" by the [factory method](https://www.dofactory.com/net/factory-method-design-pattern) pattern, since it doesn't use *Creator* classes, instead the objects are created using a switch statement.
The `Bug` classes are analogous to the *Product* classes in the pattern.

### Class Diagram

```mermaid
---
title: Bug Classes
---
classDiagram
class Bug {
    <<interface>>
  + Name: string
  + Move(): string
  + Kill(exterminator: string): bool
}

class Cockroach {
  - Name: string = "cockroach"
  + Move(): string
  + Kill(exterminator: string): bool
}

class Fly {
  - Name: string = "fly"
  + Move(): string
  + Kill(exterminator: string): bool
}

    Bug <|-- Cockroach
    Bug <|-- Fly
```

## Project 2: TBD
This project will include classes that are analogous to the *Creator* classes in the *factory method* design pattern.

