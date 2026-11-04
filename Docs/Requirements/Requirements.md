# Working on
## Create Test Cases
Base on the previous version

## Have only 1 solution
1. Generate Percentage data type based on the old version
1. Remove the previous version and move the new version to the root of the repository.
1. Create version 2.0 of the Random Number Generator (RNG) application.
1. Publish and deploy the new version of the Random Number Generator (RNG) application to GitHub
1. Delete the branch "Updates"

## Validate the need for fairness in random number generation.
Do we really need to ensure the "Is Fair" functionality?  Are we missing results because of this?

## Engines
My recommendations

For a Windows/.NET project, I would choose these six:

Microsoft Random
Microsoft RandomNumberGenerator
PCG64
Xoshiro256**
ISAAC
ChaCha20 DRBG

https://rosettacode.org/wiki/Random_number_generator_(included)
https://duckduckgo.com/?t=ffab&q=Blum+Blum+Shub+C%23+Example&ia=web

Research
Engine	                Speed	    Memory	Statistical Quality	Cryptographically Secure	Notes
Xoshiro256**	        ★★★★★	Tiny	Excellent			No							Extremely fast
SplitMix64	            ★★★★★	Tiny	Very Good			No							Great seeding engine
ISAAC	                ★★★★	    Small	Excellent			Historically yes			Independent algorithm
ChaCha20 DRBG	        ★★★★	    Small	Excellent			Yes							Independent CSPRNG

Additional engines to research:
https://www.pcg-random.org/
https://en.wikipedia.org/wiki/List_of_random_number_generators

## Engines not usable
Engine	                Speed	    Memory	Statistical Quality	Cryptographically Secure	Notes
PCG64	                ★★★★★	Tiny	Excellent			No							One of the best all-around PRNGs
- Minimal C Version:
  - Can use: https://github.com/imneme/pcg-c-basic (Minimal C Version)
  - Documentation: https://www.pcg-random.org/using-pcg-c-basic.html
Reason:
- This expects the class to be running the full time of the application is running.  The engines used need
to be able to be started, generate the number and stopped at any time.  This engine is not suitable.


## ChatGPT "Help"
You wanted to start with Xoshiro256, then you are going back to PCG64.  I am not following your direction;
and therefore I do not know how to work with you.

We have a list of engines to look at, this is great.
We want to implement 1 engine at a time, this is also great.
We need a working example to get started with, this appears to be a problem.  C/C++ are different languages and must
be compiled completely different.  Most of the examples online assume you are running LINUX with gcc or something
similar.  Without understanding their code in C/C++, I will not be able to convert to a working C# library that will
work in .NET 9+ and netstandard 2.1.

Is this how the Codex will work if I download it to work with?  Codex would be able to see the code, here I would have
to explain the code or attach the code to the prompt.  In either case, it appears to be impossible to stay focused on
the task at hand.  Or is this how your engine is designed to work: Pure theory, and keep changing the theory once a
decision has been made?