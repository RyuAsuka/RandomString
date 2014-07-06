using System;
using System.Text;

namespace RandomString
{
    /// <summary>
    /// 随机字符串产生类
    /// </summary>
    public static class RandomStringImpl
    {
        /// <summary>
        /// 产生指定长度的随机字符串（包含所有字母和数字）
        /// </summary>
        /// <param name="length">要产生的字符串的长度</param>
        /// <returns>随机字符串</returns>
        public static string CreateRandomString(int length)
        {

            string[] allCharArray = {"0","1","2","3","4","5","6","7","8","9",
                                     "a","b","c","d","e","f","g","h","i","j",
                                     "k","l","m","n","o","p","q","r","s","t",
                                     "u","v","w","x","y","z","A","B","C","D",
                                     "E","F","G","H","I","J","K","L","M","N",
                                     "O","P","Q","R","S","T","U","V","W","X",
                                     "Y","Z"};
            StringBuilder randomString = new StringBuilder();
            int temp = -1; //记录上次随机数的数值，尽量避免产生几个相同的随机数

            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(62);
                if (temp == t)
                {
                    return CreateRandomString(length);
                }
                temp = t;
                randomString.Append(allCharArray[t]);
            }
            return randomString.ToString();
        }

        /// <summary>
        /// 产生随机数字的字符串
        /// </summary>
        /// <param name="length">随机字符串的长度</param>
        /// <returns>随机数字字符串</returns>
        public static string CreateRandomNumberString(int length)
        {
            string[] numArray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            StringBuilder randamNumber = new StringBuilder();
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(1*temp*((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(10);
                if (temp == t)
                {
                    return CreateRandomNumberString(length);
                }
                temp = t;
                randamNumber.Append(numArray[t]);
            }
            return randamNumber.ToString();
        }
    }
}
