using System;

namespace BasicsMethodsGroup2
{
    class Program
    {
        public static string GenerateStudentId(string prefix)
        {
            Random generator = new Random();
            int id = generator.Next(10000000);

            string result = "" + id;        // Convert.ToString(id)
            result = result.PadLeft(7, '0');

            return prefix + result;
        }

        public static string GenerateStudentEmail(string firstname,
            string lastname)
        {
            string result = firstname + "." + lastname + "@student.vives.be";
            result = result.ToLower().Replace(" ", "");
            return result;
        }

        static void Main(string[] args)
        {
            // 1) Genereer een s/r nummer voor studenten
            // s0123456 of r0123456
            string studentID = GenerateStudentId("s");
            Console.WriteLine("Student ID = " + studentID);

            // 2) Generate student email
            Console.WriteLine("Please enter your firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your lastname: ");
            string lastname = Console.ReadLine();

            string email = GenerateStudentEmail(firstname, lastname);
            Console.WriteLine(email);

        }
    }
}
