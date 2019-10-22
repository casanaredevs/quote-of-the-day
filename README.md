# Coding Dojo CasanareDevs. Kata 3

Tercer Capítulo del Coding Dojo - Construcción de un API REST en .NET Core 3

El objetivo de esta kata es conocer el funcionamiento básico de .NET y desarrollar un servicio web (Web API REST) bajo ASPNET Core 3

## Contenido

- [Requerimiento](##Requerimiento).
- [Prerequisitos](##Prerequisitos).
- [Comandos básicos para trabajar en .NET CLI](##Comandos-básicos-para-trabajar-en-.NET-CLI)
- [Paso a paso](##Paso-a-paso).

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

## Comandos básicos para trabajar en .NET CLI

Para instalar los paquetes de nuget en el proyecto ejecute

    dotnet restore

Para Compilar un proyecto, en la carpeta donde se encuentre el .csproj ejecute

    dotnet build

Para ejecutar un proyecto, en la carpeta donde se encuentre el .csproj ejecute

    dotnet run 

Para ejecutar un proyecto de pruebas unitarias, en la carpeta donde se encuentre el proyecto de pruebas ejecute.

    dotnet test

## Paso a paso

El objetivo es ir avanzando en cada uno de los pasos. Se dejará un enlace al commit previo al inicio del paso y al final.

### -1. Una breve explicación de .NET

Como introducción tomé una presentación del [dotnet-foundation](https://presentations.dotnetfoundation.org) y las personalicé para dar los primeros pasos en .NET .

Descargar presentación [¿Que es .NET?](slides/WhatIsdotNET.pptx)

Estado del repositorio [Link](https://github.com/casanaredevs/quote-of-the-day/tree/8bce991ead76eac9a955f573f8361cf1f80d2e99)

### 0. Creación de la estructura de carpetas y arquitectura

La estructura básica del proyecto corresponde a la siguiente estructura:

    -root
        -src
        -test

Usarémos una arquitectura sencilla, en la cual tendremos los siguientes componentes:

- Modelos. Clases POCO (Plain Old CLR Object).
- DataAccess. Libreria para el acceso a los datos que no depende del Destino. Implementa los siguientes patrones de diseño:

  - Patrón Repositorio [Repository Pattern](https://martinfowler.com/eaaCatalog/repository.html).
  - Unidad de Trabajo [Unit of Work](https://martinfowler.com/eaaCatalog/unitOfWork.html).
- Services. Con estos dos proyecto se busca facilitar el uso de los conceptos de Segregación de Interfaces e Inversión de Dependencias  [SOLID](https://thatcsharpguy.com/posts/los-principios-solid/).
  - Contratos. Definición de Interfaces.
  - Implementación. Implementación de la Interfaz.
- WebAPI. Proyecto implementado en ASPNET Core que entregará mediante REST las frases del dia y del mes.
- Test. Proyecto de Pruebas Unitarias

### 1. Creación de Solución

Una solución es un elemento que nos permite agrupar proyectos.

``` Console
dotnet new sln -n QuoteOfTheDay
```

Una solución es un elemento que nos permite agrupar proyectos.

.NET tiene un CLI muy poderoso que nos permite acceder a todas las funcionalidades y opciones de la plataforma.

La solución debe ser creada en la carpeta **src**

``` Console
cd src
```

En esta carpeta ejecutamos el comando

``` Console
dotnet new sln -n QuoteOfTheDay
```

### 2. Modelos (Entities)

Este proyecto contendrá las clases que representarán el modelo. Ejecute el siguiente comando en la carpeta **src**

``` Console
dotnet new classlib -n QOTD.Models
```

Opcional. para agregar el proyecto a la solución puede escribir

``` Console
dotnet sln QuoteOfTheDay.sln add QOTD.Models
```

El modelo consiste de las siguientes:

![Modelo](https://irlv0a.by.files.1drv.com/y4m1flysX2_OFpFAM9LL50OGyL0-J66Fz1_LAGupHCZjw3kqUBAHp4GIOxD6mA3L0WATy6vjpmr9GgqkHfhJQNj2RJZDBffeK3cbOJJYTota3jp_xe2Ph5V3CmGy1OejhMNqv6yaiqcGrJPBuDo_0J_00go4ygdlUDeh_1R1OeQl-3WAM1jswvWT25myLRTIQt1_SXRi-oI-0CLtDZ5ejTogA?width=477&height=176&cropmode=none)

La implementación es como sigue:

Categoria

```csharp
//Categoria.cs
using System.Collections.Generic;
namespace QOTD.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IList<Frase> Frases { get; set; }        
    }
}
```

Frase

```csharp
//Frase.cs
using System;
namespace QOTD.Models
{
    public class Frase
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public Categoria Categoria { get; set; }
    }
}
```

El modelo consiste de las siguientes:

![Modelo](https://irlv0a.by.files.1drv.com/y4m1flysX2_OFpFAM9LL50OGyL0-J66Fz1_LAGupHCZjw3kqUBAHp4GIOxD6mA3L0WATy6vjpmr9GgqkHfhJQNj2RJZDBffeK3cbOJJYTota3jp_xe2Ph5V3CmGy1OejhMNqv6yaiqcGrJPBuDo_0J_00go4ygdlUDeh_1R1OeQl-3WAM1jswvWT25myLRTIQt1_SXRi-oI-0CLtDZ5ejTogA?width=477&height=176&cropmode=none)

La implementación es como sigue:

Categoria

```csharp
//Categoria.cs
using System.Collections.Generic;
namespace QOTD.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IList<Frase> Frases { get; set; }        
    }
}
```

Frase

```csharp
//Frase.cs
using System;
namespace QOTD.Models
{
    public class Frase
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public Categoria Categoria { get; set; }
    }
}
```

### 3. Repositorio (DataAccess)

Este proyecto contendrá el Contexto (Clase que accede al origen de datos) y los Repositorios. Ejecute el siguiente comando en la carpeta

``` Console
dotnet new classlib -n QOTD.DataAccess
```

Este proyecto referenciará **unicamente** al proyecto Models, para agregar esta referencia

``` Console
dotnet add QOTD.DataAccess reference QOTD.Models
```

Opcional. para agregar el proyecto a la solución puede escribir

``` Console
dotnet sln QuoteOfTheDay.sln add QOTD.DataAccess
```

### 4. Servicios (Contratos e Implementación)

Se crearán dos proyectos, uno contendrá los contratos y otro la implementación de los contratos.

``` Console
dotnet new classlib -n QOTD.Services.Contracts
dotnet new classlib -n QOTD.Services.Implementation
```

Ambos proyectos referenciarán a Models.

``` Console
dotnet add QOTD.Services.Contracts reference QOTD.Models
dotnet add QOTD.Services.Implementation reference QOTD.Models
```

Adicionalmente, el proyecto de implementación referencia el proyecto de Contratos

``` Console
dotnet add QOTD.Services.Implementation reference QOTD.Services.Contracts
```

Opcional. para agregar el proyecto a la solución puede escribir

``` Console
dotnet sln QuoteOfTheDay.sln add QOTD.Services.Contracts
dotnet sln QuoteOfTheDay.sln add QOTD.Services.Implementation
```

### 5. WebAPI

El proyecto WebApi es el que se encargará de escuchar y contestar las solicitudes HTTP

``` Console
dotnet new webapi -n QOTD.WebApi
```

Este proyecto referenciará a todos los demas

``` Console
dotnet add QOTD.WebApi reference QOTD.DataAccess QOTD.Models QOTD.Services.Contracts QOTD.Services.Implementation
```

Opcional. para agregar el proyecto a la solución puede escribir

``` Console
dotnet sln QuoteOfTheDay.sln add QOTD.WebApi
```

### 6. Proyecto de pruebas unitarias

Este proyecto tendrá acceso a todas las pruebas unitarias, este comando debe ejecutarse en la carpeta **test**

``` Console
    dotnet new xunit -n QOTD.Test
```

Agreguemos a este proyecto las referencias a los demas proyectos. Para hacerlo abra el archivo QOTD.Test.csproj y escriba antes de la etiqueta **Project**

    <ItemGroup>
        <ProjectReference Include="..\..\src\QOTD.DataAccess\QOTD.DataAccess.csproj" />
        <ProjectReference Include="..\..\src\QOTD.Models\QOTD.Models.csproj" />
        <ProjectReference Include="..\..\src\QOTD.Services.Contracts\QOTD.Services.Contracts.csproj" />
        <ProjectReference Include="..\..\src\QOTD.Services.Implementation\QOTD.Services.Implementation.csproj" />
    </ItemGroup>

Desde la carpeta **src** debemos agregar el proyecto a la solución

``` Console
dotnet sln QuoteOfTheDay.sln add ..\test\QOTD.Test 
```

## Avance

 1. Arquitectura creada [commit](https://github.com/casanaredevs/quote-of-the-day/tree/f61b70b0d64a6bcd8870586cb31be13a69b9924a).
 2. Modelos creados [commit](https://github.com/casanaredevs/quote-of-the-day/tree/469779619ce7a52f563dd31b96bde8922a58a985).
 3. Repositorio creado [commit]()
 4. Servicios creados [commit]()
 5. WebApi Creada [commit]()