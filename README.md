# Goke.Plotly.Blazor

I needed plotly in Blazor.

[![sample image](sample.png)](https://goke-ai.github.io/plotly-blazor/)

## Installation Guide

- Install .NET Core SDK 3.1 or later, .NET 5 is even better.

Create a new Blazor Server or Webassembly project.

- `dotnet new blazorserver`
- `dotnet new blazorwasm`

Add the nuget package

- Package Manager: `Install-Package Goke.Plotly.Blazor`
- .Net CLI: `dotnet add package Goke.Plotly.Blazor`
- PackageReference: `<PackageReference Include="Goke.Plotly.Blazor" />`
- Packet CLI: `paket add Goke.Plotly.Blazor`
- Nuget Manager in Visual Studio: search for `Goke.Plotly.Blazor`.

Add the following to the Index.html in Blazor WebAssembly or App.razor Blazor Server

- <script src="_content/Goke.Plotly.Blazor/plotly-latest.min.js" type="text/javascript" language="javascript"></script>
- <script src="_content/Goke.Plotly.Blazor/plotly-js-interop.js" type="text/javascript" language="javascript"></script>

## Demo link below

<https://goke-ai.github.io/plotly-blazor/>

## Sample Code

## Donation
