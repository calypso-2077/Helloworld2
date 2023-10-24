using System;



namespace Helloworld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task #1

            var fullname = "Авад Халид ";
            short age = 15;
            var email = "lol123321@gmail.com";
            float prog = 67.6f;
            float math = 99.9f;
            float physic = 85.5f;

            Console.WriteLine(fullname + age);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Programin: " + prog);
            Console.WriteLine("Math: " + math);
            Console.WriteLine("Physic: " + physic);

            Console.ReadLine();

            //Task #2

            double a = prog + math + physic;

            Console.WriteLine("Сумма всех баллов: " + a);
            Console.ReadLine();
            Console.WriteLine("Общий арефметический балл: " + a / 3);
            Console.ReadLine();


            



        }

        
    }
}
