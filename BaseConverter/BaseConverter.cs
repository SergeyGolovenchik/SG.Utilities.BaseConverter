﻿namespace SG.Utilities;

public class BaseConverter : IBaseConverter
{
    /// <summary>
    /// Alphabet of base converter
    /// </summary>
    public string Alphabet { get; }
    /// <summary>
    /// Base value of converter
    /// </summary>
    public byte Base { get; }
    /// <summary>
    /// Size of conversion buffer
    /// </summary>
    private readonly byte _bufferSize;
    /// <summary>
    /// Alphabet dictionary to count character value
    /// </summary>
    private readonly Dictionary<char, byte> _alphabet = new Dictionary<char, byte>();

    /// <summary>
    /// Creates base converter with custom alphabet
    /// </summary>
    /// <param name="alphabet">Alphabet of base</param>
    /// <exception cref="ArgumentOutOfRangeException">Alphabet must contain at least 2 characters</exception>
    /// <exception cref="ArgumentException">Alphabet should contain only unique characters</exception>
    public BaseConverter(string alphabet)
    {
        if (alphabet is null || alphabet.Length < 2)
        {
            throw new ArgumentOutOfRangeException(message: "Alphabet must contain at least 2 characters", paramName: "alphabet");
        }

        this.Alphabet = alphabet;
        this.Base = (byte)alphabet.Length;
        this._bufferSize = (byte)Math.Ceiling(Math.Log(UInt64.MaxValue, alphabet.Length));

        for (int i = 0; i < alphabet.Length; i++)
        {
            if (!_alphabet.ContainsKey(alphabet[i]))
            {
                _alphabet.Add(alphabet[i], (byte)i);                 // Filling dictionary with characters value based on it's positions in alphabet
            }
            else
            {
                throw new ArgumentException(message: $"Alphabet contains duplicated character '{alphabet[i]}'.", paramName: "alphabet");
            }
        }
    }

    /// <summary>
    /// Converts Base10 value to BaseN
    /// </summary>
    /// <param name="value">Value to convert</param>
    /// <returns>Converted value</returns>
    public virtual string ConvertFromDec(long value)
    {
        var uValue = (ulong)value;                                   // Type convertion to properly convert negative values
        var buffer = new char[this._bufferSize];                     // Buffer array to keep convertion results
        var i = this._bufferSize;                                    // Buffer free space counter

        do                                                           // Conversion process
        {
            buffer[--i] = Alphabet[(byte)(uValue % this.Base)];
            uValue = uValue / this.Base;
        }
        while (uValue > 0);

        var result = new char[this._bufferSize - i];                 // Array for result of proper size
        Array.Copy(buffer, i, result, 0, this._bufferSize - i);      // Copying to result

        return new string(result);                                   // Converting to string
    }

    /// <summary>
    /// Converts BaseN value to Base10
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Number in decimal base</returns>
    public virtual long ConvertToDec(string value)
    {
        var result = (ulong)0;                                      // Type conversion to properly convert negative values
        var valueLength = value.Length;                             // Calculating string length for usage below

        for (int i = 0; i < valueLength; i++)
        {
            var poweredIndex = (ulong)Math.Pow(this.Base, i);       // Powering base
            var valueChar = value[valueLength - (i + 1)];           // Getting char to get it's value from alphabet dictionary

            result += poweredIndex * _alphabet[valueChar];          // Sum the result
        }

        return (long)result;                                        // Back conversion to support negative values
    }
}