using System;
using RandomString;

namespace RandomStringTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(RandomStringImpl.CreateRandomNumberString(8));
            Console.WriteLine(RandomStringImpl.CreateRandomString(20));
        }
    }
}
