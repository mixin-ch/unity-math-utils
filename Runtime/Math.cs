
namespace Mixin
{
    public static class Math
    {
        /// <summary>
        /// Calculates the modulo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="modulus"></param>
        /// <returns></returns>
        public static double Modulo(this double value, double modulus) { return (value % modulus + modulus) % modulus; }

        /// <summary>
        /// Ensures the value to be at least a certain size.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <returns>Returns the greater value.</returns>
        public static double LowerBound(this double value, double min) { return System.Math.Max(min, value); }

        /// <summary>
        /// Ensures the value to be at most a certain size.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="max"></param>
        /// <returns>Returns the smaller value.</returns>
        public static double UpperBound(this double value, double max) { return System.Math.Min(max, value); }

        /// <summary>
        /// Ensures the value to be inside a certain range.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <returns>Returns the bounded value.</returns>
        public static double Between(this double value, double min, double max) { return value.LowerBound(min).UpperBound(max); }

        /// <summary>
        /// Rounds the number down.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Floor(this double value) { return (long)System.Math.Floor(value); }

        /// <summary>
        /// Rounds the number up.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Ceiling(this double value) { return (long)System.Math.Ceiling(value); }

        /// <summary>
        /// Randomly returns either true or false.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="probability">Probability to return true.</param>
        /// <returns></returns>
        public static bool RandomTrue(this double probability, System.Random random) { return random.NextDouble() < probability; }

        /// <summary>
        /// Returns randomly either floor or ceil dependant on the value.
        /// "3.8" has 80% chance of "4" and 20% chance of "3".
        /// </summary>
        /// <param name="value"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        public static long RoundRandom(this double value, System.Random random)
        {
            return value.Floor() + (value.Modulo(1).RandomTrue(random) ? 1 : 0);
        }

        /// <inheritdoc cref="Modulo(double, double)" />
        public static float Modulo(this float value, float modulus) { return (float)Modulo((double)value, modulus); }
        /// <inheritdoc cref="Modulo(double, double)" />
        public static long Modulo(this long value, long modulus) { return (long)System.Math.Round(Modulo((double)value, modulus)); }
        /// <inheritdoc cref="Modulo(double, double)" />
        public static int Modulo(this int value, int modulus) { return (int)Modulo((long)value, modulus); }

        /// <inheritdoc cref="LowerBound(double, double)" />
        public static float LowerBound(this float value, float min) { return (float)LowerBound((double)value, min); }
        /// <inheritdoc cref="LowerBound(double, double)" />
        public static long LowerBound(this long value, long min) { return (long)System.Math.Round(LowerBound((double)value, min)); }
        /// <inheritdoc cref="LowerBound(double, double)" />
        public static int LowerBound(this int value, int min) { return (int)LowerBound((long)value, min); }

        /// <inheritdoc cref="UpperBound(double, double)" />
        public static float UpperBound(this float value, float max) { return (float)UpperBound((double)value, max); }
        /// <inheritdoc cref="UpperBound(double, double)" />
        public static long UpperBound(this long value, long max) { return (long)System.Math.Round(UpperBound((double)value, max)); }
        /// <inheritdoc cref="UpperBound(double, double)" />
        public static int UpperBound(this int value, int max) { return (int)UpperBound((long)value, max); }

        /// <inheritdoc cref="Between(double, double, double)" />
        public static float Between(this float value, float min, float max) { return (float)Between((double)value, min, max); }
        /// <inheritdoc cref="Between(double, double, double)" />
        public static long Between(this long value, float min, long max) { return (long)System.Math.Round(Between((double)value, min, max)); }
        /// <inheritdoc cref="Between(double, double, double)" />
        public static int Between(this int value, float min, int max) { return (int)Between((long)value, min, max); }

        /// <inheritdoc cref="Floor(double)" />
        public static long Floor(this float value) { return Floor((double)value); }

        /// <inheritdoc cref="Ceiling(double)" />
        public static long Ceiling(this float value) { return Ceiling((double)value); }

        /// <inheritdoc cref="RandomTrue(double, System.Random)" />
        public static bool RandomTrue(this float probability, System.Random random) { return RandomTrue((double)probability, random); }

        /// <inheritdoc cref="RandomTrue(double, System.Random)" />
        public static long RoundRandom(this float value, System.Random random) { return RoundRandom((double)value, random); }
    }
}
