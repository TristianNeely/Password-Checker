using System;

namespace PasswordCheckerCodeCademyProject
{
    class Program
    {

        static Random randomObject = new Random();
        static void Main(string[] args)
        {

            int minLength = 4;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "12345678910";
            string specialChars = "#*%$&(#@-";

            int score = 0;
            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
            Console.WriteLine("Please Enter a password to determine it's strength.");
            string password = Console.ReadLine();
            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
            Console.WriteLine($"You entered the password: {password}. ");

            if (password.Length >= minLength)
            {
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                score++;
                Console.WriteLine($"Nice job on length. You get a point. Your Score is = {score}");
             
                
                if (Tools.Contains(password, uppercase))
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    ++score;
                    Console.WriteLine($"Nice job on using UPPERCASE. You get a point. Your Score is = {score}");

                }

                if (Tools.Contains(password, lowercase))
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    ++score;
                    Console.WriteLine($"Nice job on using lowercase. You get a point. Your Score is = {score}");

                }
                if (Tools.Contains(password, digits))
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    ++score;
                    Console.WriteLine($"Nice job on using digits. You get a point. Your Score is = {score}");

                }
                if (Tools.Contains(password, specialChars))
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    ++score;
                    Console.WriteLine($"Nice job on using Special Characters. You get a point. Your Score is = {score}");
                    Console.WriteLine(score);

                }

                switch (score)
                {
                    case 5:
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.Write("The password is extremely strong");
                        break;
                    case 4:
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.Write("The password is extremely strong");
                        break;
                    case 3:
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("The password is strong");
                        break;
                    case 2:
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("The password is medium");
                        break;
                    case 1:
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("The password is weak");
                        break;
                    default:
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("Hmm.. Im not sure");
                        break;




                }


            }

        }
        
    }
}
