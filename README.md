# BepInExModTemplate for Obenseuer

This repo is a series of files designed to get you modding Obenseuer as quickly and easily as possible!

- [Installing (Nuget)](#installing-nuget)
- [Installing (Manually)](#installing-manually)
- [Using](#using)
  - [Setting Up The Config File](#setting-up-the-config-file)
- [Manually Using the Build Directives](#manually-using-the-build-directives)

## Installing (Nuget)

Run the following command

```bash
dotnet new install dev.mamallama.OSBepInExModTemplate
```

## Installing (Manually)

- Download this repo's source or clone it to your local computer.
- Navigate inside the DotNetTemplate folder
- Open a Terminal/Powershell/Bash window inside this folder and use the following command to install it: `dotnet new install .`
  - Note: If you are updating the template from an older version use `dotnet new install . --force` instead

Great! The template is now installed locally as OSBepinPlugin

## Using

- Create a new folder wherever you'd like your new project to be
- Give it a nice name, this folder name will be your whole project's name
- Open a Terminal/Powershell/Bash window inside this folder and use the following command to instance a new plugin `dotnet new OSBepinPlugin`

You now have a (mostly) working setup. For automated build copying you'll need to follow some extra steps!

### Setting Up The Config File

At the root of your new project you should see `Config.Build.user.props.template` this is a special file that is the template for the project's config. It needs to know where your copy of the game is.
Make a copy of this file and rename it `Config.Build.user.props` without the template part. Open it in a text editor and replace `full/path/to/game` inside `<GameDir>full/path/to/game</GameDir>` with the actual full path to your game. This is the path when you right click the game in your Steam library and select "Browse Local Files"
Save the file and you're ready to start making a mod!

## Manually Using the Build Directives

I've tried to include both Visual Studio and Visual Studio Code tasks for building and deploying the plugin to your game directory but if for some reason these don't work you can use the following commands in the terminal in your project folder that contains the `.sln` file

> [!NOTE]  
> These actions depend on the config file being set up!

- `dotnet build -p:DeployToProd=true` to build and deploy to your plugins folder
- `dotnet build -p:BuildStaging=true` to build the project and zip it up in the `artifacts` folder. This zip will be suitable for github releases

> [!WARNING]
> The BuildToStaging action depends on your project having a LICENSE file in the root folder alongside the solution file!
