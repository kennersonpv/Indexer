using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "James St Patrick";
            cookie.Expiry = new DateTime(1981, 05, 07);
            System.Console.WriteLine(cookie["name"]);
            System.Console.WriteLine(cookie.Expiry);
        }
    }
}
