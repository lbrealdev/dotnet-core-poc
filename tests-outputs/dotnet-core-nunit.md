# .NET Core - NUnit Unit Tests

```shell
root@412626bc8903:/home# dotnet test --logger "console;verbosity=detailed"
Test run for /home/ExampleCoreLib2Test/bin/Debug/netcoreapp3.1/ExampleCoreLib2Test.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.7.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
/home/ExampleCoreLib2Test/bin/Debug/netcoreapp3.1/ExampleCoreLib2Test.dll
NUnit Adapter 4.3.0.0: Test execution started
Running all tests in /home/ExampleCoreLib2Test/bin/Debug/netcoreapp3.1/ExampleCoreLib2Test.dll
   NUnit3TestExecutor discovered 5 of 5 NUnit test cases using Current Discovery mode, Non-Explicit run
NUnit Adapter 4.3.0.0: Test execution complete
  √ Add_ShouldReturnCorrectResult [15ms]
  √ Divide_ByZero_ShouldThrowDivideByZeroException [7ms]
  √ Divide_ShouldReturnCorrectResult [< 1ms]
  √ Multiply_ShouldReturnCorrectResult [< 1ms]
  √ Subtract_ShouldReturnCorrectResult [< 1ms]

Test Run Successful.
Total tests: 5
     Passed: 5
 Total time: 2.0322 Seconds
```