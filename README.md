# NetCoreGlow
[![Build Status](https://dev.azure.com/justinwiblin/NetCoreGlow/_apis/build/status/Thelonedevil.NetCoreGlow?branchName=master)](https://dev.azure.com/justinwiblin/NetCoreGlow/_build/latest?definitionId=1&branchName=master)

## Prerequisites
 - OpenGL support in your environment
 - [GLFW](https://www.glfw.org/) compiled for your environment, [source here](https://github.com/glfw/glfw)

 
 ## Installation

Install stable and development releases via Nuget;

| Package Name                   | Release (NuGet) | Dev (NuGet) |
|--------------------------------|-----------------|-------------|
| `NetCoreGlow`         | [![NuGet](https://img.shields.io/nuget/v/NetCoreGlow.svg)](https://www.nuget.org/packages/NetCoreGlow/)| [![NuGet](https://img.shields.io/nuget/vpre/NetCoreGlow.svg)](https://www.nuget.org/packages/NetCoreGlow/)|

## Getting Started 
 1. First you need to make sure the [GLFW](https://www.glfw.org/) library is available from the program's working directory
 
 2. Then you need to decide on what version of OpenGL you want to target, and what size your window should be then call
 ```c#
 GL.Initialise(OpenGLMajorVersion, OpenGLMinorVersion, WindowWidth, WindowHeight)
 ```
 
 3. Then you can access the bindings for that version of OpenGL via:
 ```c#
 GL.GL<OpenGLMajorVersion><OpenGLMinorVersion>
 ```
 
 For example using OpenGL 3.2 with a window of 800x600
 
 ```c#
 var window = GL.Initialise(3,2,800,600);
 var gl = GL.GL32;
 ```
