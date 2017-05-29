using System;
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//http://telerikacademy.com/Courses/Courses/Details/212

namespace _12.ParseURL
{
    class StUpParseURL
    {
        static void Main()
        {
            string address = Console.ReadLine();


            int endProt = address.IndexOf("://");
            string protokol = address.Substring(0, endProt);
            // Console.WriteLine(protokol);

            string sub = address.Substring(endProt + 3);
            // Console.WriteLine(sub);
            int endServ = sub.IndexOf("/");
            string server = sub.Substring(0, endServ);

            string resource = sub.Substring(endServ);

            Console.WriteLine("[protokol] = {0}\n[server] = {1}\n[resource] = {2}", protokol, server, resource);

        }
    }
}
