# Version 3.1.0
## Bug Fixes
1. Updated the path naming of the .NET 10 project to reflect the .NET version being used.

# Version 3.0.0
## Application Updates
1. The method Microsoft RNGCryptoServiceProvider was removed from the Random Number Generator (RNG) application.
This Is replaced by the RandomNumberGenerator class that is already being used.  The formula for generating a
random number is the same, but the implementation is different.

1. The method Xoshiro256StarStar was added to the Random Number Generator (RNG) application.  This is a fast
and efficient random number generator that is suitable for use in applications that require high-quality random
numbers.

## Development Updates
1. Added a shared project that contain the core logic of the Random Number Generator (RNG).
1. There are 2 libraries that are created from the shared project.  One is for .NET 10+ and the other is for
netstandard 2.1.  This allows the Random Number Generator (RNG) application to be used in multiple
applications that are created in different .NET versions.

