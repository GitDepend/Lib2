# Lib2
Example Repository for [GitDepend](https://github.com/GitDepend/GitDepend)

This is the 2nd level repository.

## Building
To build this repository you must have Visual Studio 2015 installed.

Ensure all dependencies are cloned and have nuget packages available by running `make.bat update`. This will run `GitDepend update`

Build the solution with `make.bat`

## GitDepend Configuration

`GitDepend.json`

```json
{
  "name": "Lib2",
  "build": {
    "script": "make.bat"
  },
  "packages": {
    "dir": "artifacts/NuGet/Debug"
  },
  "dependencies": [
    {
      "name": "Lib1",
      "url": "https://github.com/GitDepend/Lib1.git",
      "dir": "../Lib1",
      "branch": "develop"
    }
  ]
}
```
