# Lib2
Example Repository for [GitDepend](https://github.com/kjjuno/GitDepend)

This is the 2nd level repository.

## Building
To build this repository you must have Visual Studio 2015 installed.

Ensure all dependencies are cloned and have nuget packages available by running `make.bat update`. This will run `GitDepend update`

Build the solution with `make.bat`

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
  "dependencies": [
    {
      "name": "Lib1",
      "url": "git@github.com:kjjuno/Lib1.git",
      "dir": "../Lib1",
      "branch": "develop"
    }
  ]
}
```