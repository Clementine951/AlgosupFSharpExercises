# Algosup F# - Exercises

Exercises for Algosup's F# corse.

### Prerequisites

The F# exercises needs [.Net 6.0](https://www.microsoft.com/net/download/core) to be built and run. Make sure that you have installed it before building the project. This is the current release of .NET Core that many modern F# and .NET applications use.

Additionally, the project provides [Visual Studio Code](https://code.visualstudio.com/) configuration for running.
To be able to run F# projects in Visual Studio Code, the
[Ionide plugin](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fsharp) should be also installed.

### Using dotnet-watch

You can use [dotnet-watch](https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/tutorials/dotnet-watch.md) to have your changes reloaded automatically.
To do so, navigate into `FSharpKoans` directory and run `dotnet watch test`. Now, after you change the project code, it will be automatically reloaded and tests rerun.

### Running the Koans in Visual Studio Code

Open the project directory in Visual Studio Code with Ionide-fsharp plugin installed
and press F5 to build and launch the Koans (some time is needed to build the project before launch).