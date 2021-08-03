using System;

namespace Day22_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            //object creation for class
            ValidateUserDetails validate = new ValidateUserDetails();
            validate.ValidateUser();
        }
    }
}
