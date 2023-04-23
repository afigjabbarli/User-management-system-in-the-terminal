using TaskManagement.Common;
using TaskManagement.Database;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the commands shown on the screen");
            Console.WriteLine();
            Console.WriteLine("[*] - |Register|");
            Console.WriteLine("[*] - |Login|");
            Console.WriteLine("[*] - |Exit|");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "Register":
                        RegisterCommand.Handle();
                        break;
                    case "Login":
                        LoginCommand.Handle();
                        break;
                    case "Exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
