# Unity IL2CPP + EFCore sample

GitHub issue : 13099 on EFCore repo.

This repo contains:

- A VS project of a .NET Standard 2 DLL, which uses EntityFramework Core (+ InMemory database) to create a mock DbContext.
- A Unity3D 2018.2 project, set with .NET Standard 2 and IL2CPP enabled

The VS Project ouputs the DLL in the Unity `Assets/Plugins/netstandard2.0/` folder. I also added the EntityFramework Core 2.1.2 DLL in that folder.

I know I should add all the dependencies (that's what we do with EF Core 1.1 and the old .NET scripting backend) but for the sake of simpicity of the sample I only added the main DLL. Update : the commit `f84c150c40f5388379fc8c4eff9e43f423ab7768` adds (most of) the dependencies. Revert it if you want to have only the main EFCore DLL. Notice that adding the dependencies won't fix the problem, the only change is that more DLLs are considered "broken assembly" by Unity.

The DLL in the Unity Plugins folder is the latest I compiled, so you should be able to go straight to the Unity project and see that it says "Entity EntityFramework DLL has been unloaded, broken assembly", etc.......