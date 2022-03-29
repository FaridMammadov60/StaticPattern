using System;
using System.Text.RegularExpressions;
using ConsoleApp1.AppCore.Extention;


namespace VirtualExample
{   

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("");
            string mobilNumber = "+99450-671-99-99";
            string mobilNumber2 = "050-671-99-99";
            string mobilNumber3 = "0050-671-99-99";
            
            string email = "farid.Mammadov60@gmail";
            string email2 = "farid.mammadov60@gmail.com";
            string email3 = "farid.mammadov60gmail.com";
            Console.WriteLine(Extention.IsEmail(email));
        }
      
    }
}
