# .NET Core - NUnit PoC

## Usage

Pull `dotnet-core-sdk` image:
```shell
docker pull mcr.microsoft.com/dotnet/core/sdk:3.1-buster
```

Run `dotnet-core-sdk` image:
```shell
docker run -it -v $(pwd):/home -w /home mcr.microsoft.com/dotnet/core/sdk:3.1-buster bash
```

Restore packages:
```shell
dotnet restore
```

Build project:
```shell
dotnet build /t:Rebuild 
```

Package library:
```shell
dotnet pack

or

dotnet pack -c Release
```
