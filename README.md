# Mutation testing example

Example code with 100% coverage and low mutation score

## Code
Method `MutationTestingExample.App.RangeCheck.Check`
checks whether all elements of an array are withing
bounds. Bounds are defined as two constants:
 - `MutationTestingExample.App.RangeCheck.AllowedMin`
 - `MutationTestingExample.App.RangeCheck.AllowedMax`

Algorithm for checking bounds is simple as:
1. max element of an array should be less than `AllowedMax`
2. min element of an array should be greater than `AllowedMin`

## Tests
There are two test cases defined in `RangeCheckTest` which
both together cover 100% `RangeCheck` class.

## Run

### Tests
```shell
dotnet test
```

### Coverage
```shell
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:ExcludeByFile="**/Program.cs"
```

### Mutation testing
Stryker is used for mutation testing:https://github.com/stryker-mutator/stryker-net/

Install and run:
```shell
dotnet tool install -g dotnet-stryker
dotnet stryker
```