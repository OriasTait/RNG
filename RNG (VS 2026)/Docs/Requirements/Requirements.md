# Working on
## Engines
Remove RNG engines
- Microsoft RNGCryptoServiceProvider Class
  - Is replaced by System.Security.Cryptography.RandomNumberGenerator (MS_RNG)

Research
Engine	                Speed	    Memory	Statistical Quality	Cryptographically Secure	Notes
Microsoft Random	    ★★★★★	Tiny	Good	            No	                        Baseline
RandomNumberGenerator	★★★	    Tiny	Excellent	        Yes							OS CSPRNG
PCG64	                ★★★★★	Tiny	Excellent			No							One of the best all-around PRNGs
Xoshiro256**	        ★★★★★	Tiny	Excellent			No							Extremely fast
SplitMix64	            ★★★★★	Tiny	Very Good			No							Great seeding engine
ISAAC	                ★★★★	    Small	Excellent			Historically yes			Independent algorithm
ChaCha20 DRBG	        ★★★★	    Small	Excellent			Yes							Independent CSPRNG

## For Boolean values.
Generate => Generate_Number

## Validate the need for fairness in random number generation.
Do we really need to ensure the "Is Fair" functionality?  Are we missing results because of this?
