# RNG
This is the Random Number Generator (RNG) that is used within my applications.  It is a collection of different methods of generating a random number. Everytime a number is generated, it will randomly select which of these methods are used; and then generate the random number using the selected method.

The following methods are in use:
- Microsoft Random Class (https://docs.microsoft.com/en-us/dotnet/api/system.random)
- Microsoft RNGCryptoServiceProvider Class (https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rngcryptoserviceprovider)

## Microsoft Random Class
The Microsoft Random Class is based on a modified version of Donald E. Knuth's subtractive random number generator algorithm. The chosen numbers are not completely random because a mathematical algorithm is used to select them, but they are sufficiently random for practical purposes.

### Pros
- This can be used for just about any data type, including strings and arrays.

### Cons
- The numbers generated are relatively easy to predict.
- Using the same seed will generate the same sequence of numbers.

## Microsoft RNGCryptoServiceProvider Class
The Microsoft RNGCryptoServiceProvider Class implements a cryptographic Random Number Generator (RNG) using the implementation provided by the cryptographic service provider (CSP).

### Pros
- The output is cryptographically strong random values.

### Cons
- Because the random number is a byte, the limitation is 255 different numbers.  Additional functionality needs to be created to handle a fair distribution beyond 255 different numbers.
