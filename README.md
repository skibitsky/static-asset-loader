# Static Asset Loader

> Load asset from any project directory by type

Very useful for loading configuration files of editor tools.

## Usage

```csharp
public class MyEditorWindow : EditorWindow
{
    private MyScriptableObject LoadConfiguration()
    {
        return StaticAssetLoader.LoadAsset<MyScriptableObject>();
    }
}
```

## Installation

### Install via OpenUPM

The package is available on the [openupm registry](https://openupm.com). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```
openupm add com.skibitsky.static-asset-loader
```

### Install via Git URL

Open *Packages/manifest.json* with your favorite text editor. Add the following line to the dependencies block.

    {
        "dependencies": {
            "com.skibitsky.static-asset-loader": "https://github.com/skibitsky/static-asset-loader.git"
        }
    }

Notice: Unity Package Manager records the current commit to a lock entry of the *manifest.json*. To update to the latest version, change the hash value manually or remove the lock entry to resolve the package.

    "lock": {
      "com.skibitsky.static-asset-loader": {
        "revision": "master",
        "hash": "..."
      }
    }
