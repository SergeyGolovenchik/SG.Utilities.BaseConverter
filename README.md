# SG.Utilities.BaseConverter
This library promotes BaseConverter class that allows you to convert Int64 values into desired base(radix) using some universal or your own alphabet.

## Common usage
Pass desired alphabet as a string with unique characters or use BaseAlphabet class constants
```csharp
using SG.Utilities;

IBaseConverter customBase12Converter = new BaseConverter("Unique_chars");
var inBase12 = customBase12Converter.ConvertFromDec(12345);                 // "cnha"
var fromBase12 = customBase12Converter.ConvertToDec(inBase12);              // 12345

IBaseConverter readableUrlConverter = new BaseConverter(BaseAlphabet.Base58);
// IBaseConverter readableUrlConverter = new Base58Converter();
var inBase58 = readableUrlConverter.ConvertFromDec(12345);                  // "4fr"
var fromBase58 = readableUrlConverter.ConvertToDec(inBase58);               // 12345
```

## Base2, Base8 and Base16
For this cases you don't need this library as System.Convert class do it's job perfectly. Nevertheless, there is wrapper classes Base2Converter, Base8Converter, Base16Converter that implements IBaseConverter and pass execution to System.Convert
```csharp
using SG.Utilities;

IBaseConverter converter = new Base2Converter();            // System.Convert will be used
var inBase2 = converter.ConvertFromDec(12345);              // "11000000111001"
var fromBase2 = converter.ConvertToDec(inBase2);            // 12345
```

## Changelog
#### v1.1
- **ConvertToDec(string value)** may trigger an OverflowException from now
- **ConvertToDec(string value)** trims leading zeros before conversion

## License
MIT