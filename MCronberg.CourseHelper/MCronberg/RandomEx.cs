namespace MCronberg
{

    using System;

    public class RandomEx
    {
        private static System.Random rnd = new Random();
        /// <summary>
        /// Get a random number
        /// </summary>
        /// <param name="minIncludedValue">1 = 1 is included</param>
        /// <param name="maxNotIncludedValue">7 = 7 is not not included (max=6)</param>
        /// <returns></returns>
        public static int RandomInt(int minIncludedValue, int maxNotIncludedValue) {
            return rnd.Next(minIncludedValue, maxNotIncludedValue);
        }

        public static bool RandomBool()
        {
            int v = rnd.Next(1, 101);
            if (v <= 50)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Random number between 1-6
        /// </summary>
        /// <returns></returns>
        public static int RandomDice()
        {
            return rnd.Next(1, 7);
        }

    }
}
