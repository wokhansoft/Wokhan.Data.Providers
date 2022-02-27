# DataProviders class

Utility class that hosts a list of all data providers, allowing to import new ones. Also provides method to access they columns/attributes, parameters, or to create a new instance directly.

```csharp
public static class DataProviders
```

## Public Members

| name | description |
| --- | --- |
| static [AllProviders](DataProviders/AllProviders.md) { get; } | List of all available providers (including scanned ones). |
| static [AddAssemblies](DataProviders/AddAssemblies.md)(…) | Directly add data providers from the specified assemblies. |
| static [AddPath](DataProviders/AddPath.md)(…) | Scans a folder and adds any data providers found (i.e. implementing [`IExposedDataProvider`](../Wokhan.Data.Providers.Contracts/IExposedDataProvider.md)). |
| static [AddTypes](DataProviders/AddTypes.md)(…) | Directly add data providers from the specified types. |
| static [CreateInstance](DataProviders/CreateInstance.md)(…) | Creates an instance of a provider (using it's name). Requires a dictionary describing the parameters for this provider. |
| static [GetParameters](DataProviders/GetParameters.md)(…) | Retrieves all parameters for a [`IDataProvider`](../Wokhan.Data.Providers.Contracts/IDataProvider.md). Parameters are grouped using the [`ExclusionGroup`](../Wokhan.Data.Providers.Bases/DataProviderMemberDefinition/ExclusionGroup.md) (or "Default" if null) to allow exclusive parameters to be used altogether. |

## See Also

* namespace [Wokhan.Data.Providers](../Wokhan.Data.Providers.md)
* [DataProviders.cs](https://github.com/wokhansoft/Wokhan.Data.Providers/DataProviders.cs)

<!-- DO NOT EDIT: generated by xmldocmd for Wokhan.Data.Providers.dll -->