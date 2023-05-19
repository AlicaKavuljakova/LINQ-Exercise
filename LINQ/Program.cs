using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           var videoGames=new List<string>() {"Yoshi's Cookies","Tetris","Donkey Kong","Castlevania","Silent Hill" };
            Console.WriteLine("Video Games in ascending order:");
            foreach (var videoGame in videoGames.OrderBy(x=> x.Length)) { Console.WriteLine(   videoGame); }
            Console.WriteLine("Video Games in descending order:");
            foreach (var vid in videoGames.OrderBy
                (x=> x.Length).Reverse()) { Console.WriteLine(vid); }
            Console.WriteLine("Video Games in descending order:");
            foreach (var n in videoGames.OrderByDescending(x=>x.Length)) { Console.WriteLine(n); }

        }
    }
}
/*
Create a list of video game names...
Order the list of games by length of the game name.
Use the lambda expression in this exercise as well.
Use Method Syntax for this exercise
*/