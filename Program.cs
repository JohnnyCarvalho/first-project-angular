using System;

namespace first_project_angular
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Write your last name: ");String lastName = Console.ReadLine();
            Console.Write("Write your first name: ");String firstName = Console.ReadLine();
            Console.Write("Write your years old: ");var idade = Console.ReadLine();
            //String lastName = Console.ReadLine();
            Console.WriteLine("Your name is "+lastName+" / "+firstName+", and your years old is "+idade+"\nThank you very much! ");
        
        }
    }
}
