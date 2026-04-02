using System;
using Octokit;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new GitHubClient(new ProductHeaderValue("TestOctokit"));
            client.cr
            Console.WriteLine("Hello World!");
        }
    }
}