# AbstractDataProvider class

Serves as a base class for all Data Providers.

```csharp
public abstract class AbstractDataProvider : IDataProvider
```

## Public Members

| name | description |
| --- | --- |
| [AbstractDataProvider](AbstractDataProvider/AbstractDataProvider.md)() | The default constructor. |
| virtual [AllowCustomRepository](AbstractDataProvider/AllowCustomRepository.md) { get; } |  |
| [Definition](AbstractDataProvider/Definition.md) { get; } |  |
| virtual [Host](AbstractDataProvider/Host.md) { get; set; } |  |
| virtual [Name](AbstractDataProvider/Name.md) { get; set; } |  |
| [Repositories](AbstractDataProvider/Repositories.md) { get; set; } |  |
| virtual [SelectedGroups](AbstractDataProvider/SelectedGroups.md) { get; set; } |  |
| [Type](AbstractDataProvider/Type.md) { get; } |  |
| abstract [GetColumns](AbstractDataProvider/GetColumns.md)(…) |  |
| virtual [GetDataType](AbstractDataProvider/GetDataType.md)(…) |  |
| virtual [GetDefaultRepositories](AbstractDataProvider/GetDefaultRepositories.md)() |  |
| virtual [GetFormatKey](AbstractDataProvider/GetFormatKey.md)(…) |  |
| virtual [GetFormattedValue](AbstractDataProvider/GetFormattedValue.md)(…) | Gets a formatted value for a given property. As of now... only return a string from an object. TODO: Check if really useful somewhere with the initial formatting implementation. |
| [GetQueryable](AbstractDataProvider/GetQueryable.md)(…) |  |
| abstract [GetQueryable&lt;T&gt;](AbstractDataProvider/GetQueryable.md)(…) |  |
| abstract [InvalidateColumnsCache](AbstractDataProvider/InvalidateColumnsCache.md)(…) |  |
| abstract [Test](AbstractDataProvider/Test.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [Count](AbstractDataProvider/Count.md)(…) | Gets the count for the specified repository. |
| [GetKeyType](AbstractDataProvider/GetKeyType.md)(…) |  |
| [UpdateValue](AbstractDataProvider/UpdateValue.md)(…) |  |

## See Also

* interface [IDataProvider](../Wokhan.Data.Providers.Contracts/IDataProvider.md)
* namespace [Wokhan.Data.Providers.Bases](../Wokhan.Data.Providers.md)
* [AbstractDataProvider.cs](https://github.com/wokhansoft/Wokhan.Data.Providers/Bases/AbstractDataProvider.cs)

<!-- DO NOT EDIT: generated by xmldocmd for Wokhan.Data.Providers.dll -->
