# Lib1
Example Repository for [GitDepend]()

This is the lowest level repository.

## Building
To build this repository you must have Visual Studio 2015 installed.

Run `make.bat` to build the project. Nuget Packages will be available at `artifacts\NuGet\Debug`

## GitDepend Configuration

`GitDepend.json`

```json
{
  "build": {
    "script": "make.bat"
  },
  "packages": {
    "dir": "artifacts/NuGet/Debug"
  },
  "dependencies": []
}
```