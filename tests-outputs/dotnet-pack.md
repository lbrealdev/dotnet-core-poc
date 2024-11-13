# .NET Core - Package Library


`Debug` configuration:
```shell
root@d5613f69abdf:/home# dotnet pack 
Microsoft (R) Build Engine version 16.7.3+2f374e28e for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  Running .NET core build
  ExampleCoreLib2 -> /home/ExampleCoreLib2/bin/Debug/netcoreapp3.1/ExampleCoreLib2.dll
  Successfully created package '/home/ExampleCoreLib2/bin/Debug/ExampleCoreLib2.1.0.0.nupkg'.
```

`Release` configuration:
```shell
root@d5613f69abdf:/home# dotnet pack -c Release 
Microsoft (R) Build Engine version 16.7.3+2f374e28e for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  Running .NET core build
  ExampleCoreLib2 -> /home/ExampleCoreLib2/bin/Release/netcoreapp3.1/ExampleCoreLib2.dll
  Successfully created package '/home/ExampleCoreLib2/bin/Release/ExampleCoreLib2.1.0.0.nupkg'.
```
