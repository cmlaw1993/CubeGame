#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("MqiuqDa0EGoa34S2baMB+Zy9P/UJz8b8ml3yImjMCufcQFXAypg6OoXxUw8Y5wj49CL7RvmPCQ482oyBnB11wXcpH6FFnqIw80he0kpzSJFSbIW11PznS7EJRjz9jpbJNgfuMgIdrO4rJQYrLCgoKi8vHaybN6yeT0FIDV5ZTENJTF9JDVlIX0BeDUwqwVAUrqZ+Df4V6ZySt2InRtIG0R08Ky54KSc+J2xdXUFIDWRDTgMcQ0kNTkJDSURZREJDXg1CSw1YXkhBSA1kQ04DHAsdCSsueCkmPjBsXQsdCSsueCkmPjBsXV1BSA1uSF9Z7U4eWtoXKgF7xvciDCP3l140YpgNbmwdrywPHSArJAerZavaICwsLJPZXrbD/0ki5lRiGfWPE9RV0kbl5DRf2HAj+FJytt8ILpd4omBwINwoLS6vLCItHa8sJy+vLCwtybyEJA1MQ0kNTkhfWURLRE5MWURCQw1daFMyYUZ9u2yk6VlPJj2ubKoep6ytOQb9RGq5WyTT2UagA22L2mpgUiKwEN4GZAU35dPjmJQj9HMx++YQmjaQvm8JPwfqIjCbYLFzTuVmrTp0iigkUTptezwzWf6apg4Wao74QlpaA0xdXUFIA05CQAJMXV1BSE5MOx05Ky54KS4+IGxdXUFIDX9CQlkQC0oNpx5H2iCv4vPGjgLUfkd2Sa8sLSskB6tlq9pOSSgsHazfHQcrmBeA2SIjLb8mnAw7A1n4ESD2TztdQUgNbkhfWURLRE5MWURCQw1sWKJerE3rNnYkAr+f1Wll3U0VszjYA22L2mpgUiVzHTIrLngwDik1HTu4s1chiWqmdvk7Gh7m6SJg4zlE/Bu0YQBVmsChtvHeWrbfW/9aHWLsKy54MCMpOyk5Bv1EarlbJNPZRqCmNKTz1GZB2CqGDx0vxTUT1X0k/mT1W7IeOUiMWrnkAC8uLC0sjq8sf0hBRExDTkgNQkMNWUVEXg1OSF/0G1Lsqnj0irSUH2/W9fhcs1OMf0RLRE5MWURCQw1sWFlFQl9EWVQcJQYrLCgoKi8sOzNFWVldXhcCAlpUDUxeXlhASF4NTE5OSF1ZTENOSCkrPi94fhw+HTwrLngpJz4nbF1dB6tlq9ogLCwoKC0dTxwmHSQrLngBDU5IX1lES0ROTFlIDV1CQUROVB2vKZYdry6OjS4vLC8vLC8dICskVx2vLFsdIysueDAiLCzSKSkuLywYHxwZHR4bdzogHhgdHx0UHxwZHSArJAerZavaICwsKCgtLq8sLC1xJXMdryw8Ky54MA0prywlHa8sKR1ZRUJfRFlUHDsdOSsueCkuPiBsXSsdIisueDA+LCzSKSgdLiws0h0wSqIlmQ3a5oEBDUJdmxIsHaGabuKGjly/an547IICbJ7V1s5d4MuOYR4bdx1PHCYdJCsueCkrPi94fhw+DUJLDVlFSA1ZRUhDDUxdXUFETkxfTE5ZRE5IDV5ZTFlIQEhDWV4DHTK89jNqfcYowHNUqQDGG496YXjBXUFIDX9CQlkNbmwdMzogHRsdGR9JGA44Zjh0MJ652tuxs+J9l+x1fVlES0ROTFlIDU9UDUxDVA1dTF9ZfYen+PfJ0f0kKhqdWFgM");
        private static int[] order = new int[] { 49,53,54,26,17,37,42,51,9,43,26,26,57,13,50,19,50,45,25,32,22,59,52,36,57,56,34,36,45,55,31,56,48,56,50,36,38,58,50,50,40,54,53,44,49,45,51,47,56,58,55,59,57,58,54,59,56,58,58,59,60 };
        private static int key = 45;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
