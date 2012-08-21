using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = ChuckNorris.API.Random(exclude: new string[] {"explicit"});
            var joke = response.Result;

            Console.WriteLine(joke.Text);
        }
    }
}
