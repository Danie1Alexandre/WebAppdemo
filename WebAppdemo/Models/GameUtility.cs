using System;
using Microsoft.AspNetCore.Http;
namespace WebAppdemo.Models
{
    public class GameUtility
    {
        public static string WriteMessage()
        {
            return "Guess on a number to play the game";
        }

        public int Random()
        {
            Random numbergenerator = new Random();
            return numbergenerator.Next(1,100);
        }
            
    }
}
