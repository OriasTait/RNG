# RNG
This is the Random Number Generator (RNG) that is used within my applications.  It is a collection of different methods
of generating a random number. Every time a number is generated, it will randomly select which of these methods are used;
and then generate the random number using the selected method.

The following methods are in use:
- [Microsoft Random Class](https://learn.microsoft.com/en-us/dotnet/api/system.random)
- [Microsoft RNGCryptoServiceProvider Class](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.rngcryptoserviceprovider)
- [Microsoft RandomNumberGenerator Class](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator)

At the core, the random number generated is of type long. This provides a maximum random number from
-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.  Different data types are generated by
converting to the long data type, generating the number, then converting back to the original data type.

NOTES:
- Due to the base generation being of type long, the ability to randomly generate the full selections of long/System.Int64 and
  ulong/System.UInt64 data types is not possible.

The following C# data types are able to be randomly generated:
- bool/System.Boolean	=> Structured data type that can only be "true" or "false"
- byte/System.Byte		=> Unsigned 8-bit integer  (Range: 0 to 255)
- sbyte/System.SByte	=> Signed 8-bit integer    (Range: -128 to 127)
- short/System.Int16	=> Signed 16-bit integer   (Range: -32,768 to 32,767)
- ushort/System.Int16	=> Unsigned 16-bit integer (Range: 0 to 65,535)
- int/System.Int32		=> Signed 32-bit integer   (Range: -2,147,483,648 to 2,147,483,647)
- uint/System.Int32		=> Unsigned 32-bit integer (Range: 0 to 4,294,967,295)
- ulongSystem.UInt64	=> Unsigned 64-bit integer (Range: 0 to 999,999,999,999,999,999)

The following data generation types were created:
- Percentage	=> A decimal/System.Decimal number represented with a total of 18 characters (17 digits and 1 decimal)
  (Range: 0.0000000000000000 to 100.00000000000000)

## Microsoft Random Class
The Microsoft Random Class is based on a modified version of Donald E. Knuth's subtractive random number generator
algorithm. The chosen numbers are not completely random because a mathematical algorithm is used to select them,
but they are sufficiently random for practical purposes.

### Pros
- This can be used for just about any data type, including strings and arrays.
- The implementation of different data types are built into the class.

### Cons
- The numbers generated are relatively easy to predict.
- Using the same seed will generate the same sequence of numbers.

## Microsoft RNGCryptoServiceProvider Class
The Microsoft RNGCryptoServiceProvider Class implements a cryptographic Random Number Generator (RNG) using the
implementation provided by the cryptographic service provider (CSP).

NOTES:
- As of .NET 6, this has become obsolete.  Microsoft suggests using the class RandomNumberGenerator.

### Pros
- The output is crypto-graphically strong random values.

### Cons
- The random generator only generates bytes, so the different data types need to be built to accommodate how the
  data is stored.  For example, to generate a random integer, an array of 4 bytes need to be used instead of 1.

- Additional functionality needs to be created to handle a fairly generated number.  A fair selection is considered
  to be from a full sequence of values.

For example:
If the number of selections is 6, every 6th selection would represent a new sequence:
- 1 = 1, 2 = 2, 3 = 3, 4 = 4, 5 = 5, 6 = 6
- 7 = 1, 8 = 2, 9 = 3, 10 = 4, 11 = 5, 12 = 6
- ...
- 252 = 1, 253 = 2, 254 = 3, 255 = 4
A selection of 1 - 12 would be fair because all 6 numbers are potentially available.

If the number selected is 253, this is NOT fair because not all numbers are potentially available, only 1 - 4 are
available.

## Microsoft RandomNumberGenerator Class
The Microsoft RandomNumberGenerator Class implements a cryptographic Random Number Generator (RNG) using the
implementation provided by the cryptographic service provider (CSP).

NOTES:
- As of .NET 6, this has become Microsoft's preferred class for generating random numbers; replacing the 
  RNGCryptoServiceProvider class.

- Functionality and results-wise, this is the same as the RNGCryptoServiceProvider class (see Pros/Cons).  The
  Cryptography used is stronger; and has better handling on more platforms.

### Pros
- The output is crypto graphically strong random values.

### Cons
- The random generator only generates bytes, so the different data types need to be built to accommodate how the
  data is stored.  For example, to generate a random integer, an array of 4 bytes need to be used instead of 1.

- Additional functionality needs to be created to handle a fairly generated number.  A fair selection is considered
  to be from a full sequence of values.

For example:
If the number of selections is 6, every 6th selection would represent a new sequence:
- 1 = 1, 2 = 2, 3 = 3, 4 = 4, 5 = 5, 6 = 6
- 7 = 1, 8 = 2, 9 = 3, 10 = 4, 11 = 5, 12 = 6
- ...
- 252 = 1, 253 = 2, 254 = 3, 255 = 4
A selection of 1 - 12 would be fair because all 6 numbers are potentially available.

If the number selected is 253, this is NOT fair because not all numbers are potentially available, only 1 - 4 are
available.

=============

# How to compile
This was created in Microsoft Visual Studio Community 2022.  Open the file RNG.sln in Visual Studio and compile the project.
