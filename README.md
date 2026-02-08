# Example Plugin for On-Together
A simple plugin template for [On-Together: Virtual Co-Working](https://store.steampowered.com/app/3707400/OnTogether_Virtual_CoWorking/), designed to make plugin development easier.

Please make sure you read the [BepInEx plugin tutorial](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/1_setup.html) before using!

## Other Resources
You can always ask for help in the [On-Together Discord](https://discord.gg/zeJbPJPet5)! Feel free to ping @pattersonuwu (me) in the #mod-chat channel!

> [!TIP]
> Questions or concerns about the template specifically? Tell me in the [post for this template](https://discord.com/channels/1331560256886804580/1469882271640059914).

A useful video tutorial on BepInEx plugin development can be found [here](https://www.youtube.com/watch?v=4Q7Zp5K2ywI).

A completed example plugin using this template can be found at [patttterson/BetterMediaControls](https://github.com/patttterson/BetterMediaControls).

## Notes

### Things to Change
> [!NOTE]
> The `thunderstore` directory is what gets uploaded to Thunderstore, so make sure to change the following things in there before uploading! Use the [Package Format Documentation](https://thunderstore.io/package/create/docs/) to make sure your package is valid.

- [`Plugin.cs`](./Plugin.cs)
  - `PluginGUID`
  - `PluginName`
  - `PluginAuthor`
  - `_configExampleVar`[^2]
- [`OnTogetherModTemplate.csproj`](./OnTogetherModTemplate.csproj)
  - `AssemblyName`
  - `Product`
  - `RootNamespace`
- [`thunderstore/CHANGELOG.md`](./thunderstore/CHANGELOG.md)
  - Add a changelog entry for your plugin! Please change the example entry before uploading.
- [`thunderstore/icon.png`](./thunderstore/icon.png)
  - Change the icon to something relevant to your plugin! The current one is just a placeholder. The required size is 256x256.
- [`thunderstore/manifest.json`](./thunderstore/manifest.json)
  - Use the Thunderstore [manifest validator](https://thunderstore.io/tools/manifest-v1-validator/) to make sure your manifest is valid.
- [`.github/workflows/publish.yml`](./.github/workflows/publish.yml)[<sup>*?*</sup>](#the-hell-is-githubworkflows)
  - `TS_AUTHOR`
  - `TS_NAME`

Unless your mod has *external dependencies,* everything you need should already be included in the project file. The game libraries are provided from [OnTogether.GameLibs](https://www.nuget.org/packages/OnTogether.GameLibs), which is my own package. If you need to add external dependencies, you can do so by adding them to the project file like this:
```xml
<Reference Include="ExampleLibrary">
    <HintPath>external\ExampleLibrary.dll</HintPath>
</Reference>
```

Ideally, you want to avoid external dependencies as much as possible, since they make it impossible to use [GitHub Actions](#the-hell-is-githubworkflows) to automatically build your plugin, and make it harder for other people to build and contribute. If you do need to use external dependencies, make sure to provide instructions for users on where to put them.

> [!IMPORTANT]
> This template has a `external` directory for this purpose. If you add external dependencies, please put them in there and reference them from the project file as shown above.

### Versioning[^1]
The version number of your plugin should be in the format `MAJOR.MINOR.PATCH`, where:
- `MAJOR` is incremented when you make incompatible API changes.
- `MINOR` is incremented when you add functionality in a backwards-compatible manner.
- `PATCH` is incremented when you make backwards-compatible bug fixes.

> [!TIP]
> nobody really cares.

### The hell is `.github/workflows`???
The `.github/workflows` directory contains GitHub Actions workflow files, which are used to automatically build your plugin when you push changes to your repository. The current workflow is set up to build the plugin and create a release on GitHub whenever you push a new tag in the format `vMAJOR.MINOR.PATCH`. You can customize this workflow to fit your needs, or remove it if you don't want to use it.

[^1]: https://semver.org/
[^2]: This is just an example config variable. You can change it to whatever you want, or remove it if you don't need any config variables. See how they work: https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/4_configuration.html