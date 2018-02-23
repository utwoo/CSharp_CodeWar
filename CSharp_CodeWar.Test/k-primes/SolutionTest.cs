﻿using Xunit;
using CSharp_CodeWar.k_primes;

namespace CSharp_CodeWar.Test.k_primes
{
    public class SolutionTest
    {
        private static string Array2String(long[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }
        private static void testing(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void test1()
        {
            testing(Array2String(Kata.CountKprimes(2, 0, 100)),
                    Array2String(new long[]
                    {4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 38, 39, 46, 49, 51,
                 55, 57, 58, 62, 65, 69, 74, 77, 82, 85, 86, 87, 91, 93, 94, 95}));
            testing(Array2String(Kata.CountKprimes(3, 0, 100)),
                    Array2String(new long[]
                    {8, 12, 18, 20, 27, 28, 30, 42, 44, 45, 50, 52, 63, 66, 68, 70, 75, 76,
                 78, 92, 98, 99}));
            testing(Array2String(Kata.CountKprimes(5, 1000, 1100)),
                    Array2String(new long[]
                    {1020, 1026, 1032, 1044, 1050, 1053, 1064, 1072, 1092, 1100}));
            testing(Array2String(Kata.CountKprimes(5, 500, 600)),
                    Array2String(new long[]
                    {500, 520, 552, 567, 588, 592, 594}));
        }
    }
}
