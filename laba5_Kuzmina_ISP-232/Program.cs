namespace laba5_Kuzmina_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void SayHello() =>
            //    Console.WriteLine("привет");

            //SayHello();
            //    void Game()
            //    {
            //        string myGame = "GTA V";
            //        Console.WriteLine(myGame);
            //    }
            //    Game();
            //Console.Write("введите свое имя:");
            //string? name = Console.ReadLine();
            //Console.Write("введите ваш язык(русский, немецкий, английский)");
            //string language = Console.ReadLine().ToLower();
            //void SayHelloRu() => Console.WriteLine($"привет {name}");
            //void SayHelloEn() => Console.WriteLine($"Hello {name}");
            //void SayHelloDe() => Console.WriteLine($"Guten Tag {name}");

            //switch ( language )
            //{
            //    case "русский": SayHelloRu();
            //        break;
            //    case "английский": SayHelloEn();
            //        break;
            //    case "немецкий": SayHelloDe();
            //        break;
            //    default: 
            //        Console.WriteLine("не выбрано"); break;
            //}
            //void print(string messages)
            //{
            //    Console.WriteLine(messages);
            //}
            //print("hrloh");
            //void Sum (int x, int y)
            //{
            //    int result = x + y;
            //    Console.WriteLine ($"результат {result}");
            //}
            //Sum(1, 2);
            //int y=int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //Sum(y, x);
            //void PrintPerson(string personName, int age)
            //{

            //    Console.WriteLine($"Ваше имя: {personName}");
            //    Console.WriteLine($"Ваш возраст: {age}");
            //}
            //string name = Console.ReadLine();
            //int aa = int.Parse(Console.ReadLine());
            //PrintPerson(name, aa);
            //string Message()
            //{
            //    return "Hello";
            //}
            //int Number()
            //{
            //    return 10;
            //}
            //string message = Message();
            //Console.WriteLine(message);
            //Console.WriteLine(Message());

            //string Message() => "hello";
            //Random random = new Random();
            //int number = random.Next(1, 100);
            //System.Console.WriteLine(number);

            //void Sayhello() => Console.WriteLine("Здравствуйте");
            //void Saygoodbye() => Console.WriteLine("Пока");

            //string GetWeather()
            //{
            //    string[] Weather = ["солнечно", "пасмурно", "дождливо"];
            //    Random random = new Random();
            //    int index = random.Next(Weather.Length);
            //    return Weather[index];
            //}
            //Console.WriteLine(GetWeather());

            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }
            int factorial = Factorial(n: 4);
            int factorial2 = Factorial(n: 5);
            int factorial3 = Factorial(n: 6);
            Console.WriteLine(factorial);
            Console.WriteLine(factorial2);
            Console.WriteLine(factorial3); 
            asdasdasd




        }

    }
}
