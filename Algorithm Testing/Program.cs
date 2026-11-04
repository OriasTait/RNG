using System;
using System.Buffers.Binary;
using System.Security.Cryptography;

public sealed class Xoshiro256StarStar
{
    private ulong s0, s1, s2, s3;

    public Xoshiro256StarStar(ulong seed)
    {
        // Expand single seed into 256-bit state using SplitMix64
        var sm = new SplitMix64(seed);
        s0 = sm.NextUInt64();
        s1 = sm.NextUInt64();
        s2 = sm.NextUInt64();
        s3 = sm.NextUInt64();

        // Avoid all-zero state (invalid for xoshiro)
        if ((s0 | s1 | s2 | s3) == 0)
            s0 = 0x9E3779B97F4A7C15UL;
    }

    public Xoshiro256StarStar()
        : this(CreateCryptoSeed())
    {
    }

    // Core xoshiro256** output function
    public ulong NextUInt64()
    {
        ulong result = RotL(s1 * 5, 7) * 9;
        ulong t = s1 << 17;

        s2 ^= s0;
        s3 ^= s1;
        s1 ^= s2;
        s0 ^= s3;

        s2 ^= t;
        s3 = RotL(s3, 45);

        return result;
    }

    // Inclusive range for long: [min, max]
    public long NextInt64Inclusive(long min, long max)
    {
        if (min > max)
            throw new ArgumentOutOfRangeException(nameof(min), "min must be <= max.");

        // Full long range shortcut
        if (min == long.MinValue && max == long.MaxValue)
            return unchecked((long)NextUInt64());

        // Map signed bounds to monotonic unsigned space
        ulong uMin = ToOrdered(min);
        ulong uMax = ToOrdered(max);

        ulong span = uMax - uMin + 1UL; // inclusive size

        // If span is 2^64 (only possible with full range, already handled)
        if (span == 0UL)
            return unchecked((long)NextUInt64());

        // Rejection sampling to avoid modulo bias
        ulong limit = ulong.MaxValue - ((ulong.MaxValue % span));

        ulong r;
        do
        {
            r = NextUInt64();
        } while (r >= limit);

        ulong value = uMin + (r % span);
        return FromOrdered(value);
    }

    private static ulong ToOrdered(long x) =>
        unchecked((ulong)x) ^ 0x8000_0000_0000_0000UL;

    private static long FromOrdered(ulong x) =>
        unchecked((long)(x ^ 0x8000_0000_0000_0000UL));

    private static ulong RotL(ulong x, int k) =>
        (x << k) | (x >> (64 - k));

    private static ulong CreateCryptoSeed()
    {
        Span<byte> b = stackalloc byte[8];
        RandomNumberGenerator.Fill(b);
        return BinaryPrimitives.ReadUInt64LittleEndian(b);
    }

    private sealed class SplitMix64
    {
        private ulong state;
        public SplitMix64(ulong seed) => state = seed;

        public ulong NextUInt64()
        {
            ulong z = (state += 0x9E3779B97F4A7C15UL);
            z = (z ^ (z >> 30)) * 0xBF58476D1CE4E5B9UL;
            z = (z ^ (z >> 27)) * 0x94D049BB133111EBUL;
            return z ^ (z >> 31);
        }
    }
}

public static class Program
{
    public static void Main()
    {
        var rng = new Xoshiro256StarStar();

        long min = -10;
        long max = 10;

        Console.WriteLine($"Generating 20 values in inclusive range [{min}, {max}]:");
        for (int i = 0; i < 20; i++)
        {
            long value = rng.NextInt64Inclusive(min, max);
            Console.WriteLine(value);
        }

        // Quick proof endpoints are possible (not guaranteed in tiny sample):
        Console.WriteLine("\nTry many draws to observe endpoints...");
        bool sawMin = false, sawMax = false;
        for (int i = 0; i < 1_000_000 && !(sawMin && sawMax); i++)
        {
            long v = rng.NextInt64Inclusive(min, max);
            if (v == min) sawMin = true;
            if (v == max) sawMax = true;
        }
        Console.WriteLine($"Saw min? {sawMin}, saw max? {sawMax}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}