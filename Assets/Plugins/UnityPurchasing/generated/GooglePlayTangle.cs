#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("FLnp3VVXouxg6msxchCp8XOjZcpy5mlz6M9AarA1lBiyWn7lZX/f1D6A04YkxAd1x5ktBAbESGwvjIzsxJ6H/ST4f3CPs0W9CzclCpfrLt4s9WsZBaFn6FEVhz7H7shVumb//5v6jNnqkaorGwvjACMQN4W0VXwNF08mCF7nT09VqwWqwXeteO5J/x107iYUIoZAocjjdfYKau1eJ7r5CmnfJgLZhZq8xMbv743bOzLXWLvyCLo5Ggg1PjESvnC+zzU5OTk9ODu6OTc4CLo5Mjq6OTk4869LvNe30+XFa2nHYnw8NHEM6k+ybFRPRVgT0x9r0ba2jih4fQU3Yi3cEV3ZtTXVn/FoHBMvsxBk0sCWhUgnbSvR1V3qb1BvtGEZ1To7OTg5");
        private static int[] order = new int[] { 5,4,6,6,13,9,11,7,12,9,13,13,13,13,14 };
        private static int key = 56;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
