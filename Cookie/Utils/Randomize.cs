﻿using System;
using Cookie.Utils.Extensions;

namespace Cookie.Utils
{
    public class Randomize
    {
        private static readonly Random GetRandom = new Random();
        private static readonly object SyncLock = new object();
        private static int Random(int min, int max)
        {
            lock (SyncLock)
                return GetRandom.Next(min, max);
        }

        public static int GetRandomNumber(int min, int max) => min <= max
            ? Random(min, max)
            : Random(max, min);

        public static void Run(Action action, int ms)
        {
            action.RunAfter(ms);
        }

        public static void RunBetween(Action action, int min, int max)
        {
            action.RunAfter(GetRandomNumber(min, max));
        }
    }
}
