﻿using System.Runtime.CompilerServices;

namespace EntityFX.NetBenchmark.Core.Generic
{
    public abstract class StringManipulationBase<TResult> : BenchmarkBase<TResult>
    {
        public StringManipulationBase()
        {
            Iterrations = 5000000;
            Ratio = 10;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static string DoStringManipilation(string str)
        {
            return (string.Join("/", str.Split(' ')).Replace("/", "_").ToUpper() + "AAA").ToLower().Replace("aaa", ".");
        }
    }
}
