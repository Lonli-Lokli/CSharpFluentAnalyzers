using System;

namespace FluentAndCSharpExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Helper
    {
        public static string ToAttachmentKey(this string key)
        {
            return key;
        }
    }
}