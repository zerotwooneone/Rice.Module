# Rice-Core
Remote code execution for .Net!

# To Dev
git clone --recurse-submodules https://github.com/zerotwooneone/Rice.Module


## To Build
dotnet build .\Source\Rice.Module\Rice.Module.csproj --output .\Dependencies\Rice\Rice.Module

## Projects
* Rice.Module - meant to be consumed by modules which are to be executed remotely
* Rice.Module.Abstractions - interfaces used by both module implementors as well as the process executing them
* TestModule - meant to be a simple example of a module to be sent