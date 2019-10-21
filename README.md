# Coding Dojo CasanareDevs. Kata 3

Tercer Capítulo del Coding Dojo - Construcción de un API REST en .NET Core 3

El objetivo de esta kata es conocer el funcionamiento básico de .NET y desarrollar un servicio web (Web API REST) bajo ASPNET Core 3

## Requerimiento

Web API que muestre la frase del día,la frases de un dia específico y el listado de frases de un mes especificado.

Se busca el uso de TDD, Paradigma Orientado a Objetos y los Principios SOLID.

## Prerequisitos

- .NET Core 3 SDK [Windows](https://dotnet.microsoft.com/download)/[Linux](https://dotnet.microsoft.com/download/linux-package-manager/rhel/sdk-current).
- Visual Studio Code [Descargar](https://code.visualstudio.com/).
- Extensiones de Visual Studio Code.
    - [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp).
    - [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer).
    - [vscode-solution-explorer](https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer).


## Paso a paso

### -1. Una breve explicación de .NET

Como introducción tomé una presentación del [dotnet-foundation](https://presentations.dotnetfoundation.org) y las personalicé para dar los primeros pasos en .NET .

Descargar presentación [¿Que es .NET?](slides/WhatIsdotNET.pptx)

### 0. Creación de la estructura de carpetas
La estructura básica del proyecto corresponde a la siguiente estructura:

rootfolder

-src

-test

### 1. Creación de Solución
Una solución es un elemento que nos permite agrupar proyectos.

    dotnet new sln -n QuoteOfTheDay

### 2. Modelos (Entities)

### 3. Repositorio (DataAccess)

### 4. WebAPI

