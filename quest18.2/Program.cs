namespace quest18._2
{

    public delegate float Add(float a, float b);
    public delegate float Sub(float a, float b);
    public delegate float Mul(float a, float b);
    public delegate float Div(float a, float b);

    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new();
            Add add = new Add(operation.Add);
            Sub sub = new Sub(operation.Sub);
            Mul mul = new Mul(operation.Mul);
            Div div = new Div(operation.Div);

            while (true) 
            {
                Console.WriteLine("Введите желаемую операцию [ + | - | * | / | esc ]");
                switch (Console.ReadKey(true).Key) 
                {
                    case ConsoleKey.OemPlus: 
                        {
                            Console.Clear();
                            Console.Write("Выбрана операция сложения \nВведите первое число: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            float b = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Результат сложения: {add(a, b)} \nНажмите любую кнопку для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.OemMinus:
                        {
                            Console.Clear();
                            Console.Write("Выбрана операция вычитания \nВведите первое число: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            float b = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Результат вычитания: {sub(a, b)} \nНажмите любую кнопку для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D8:
                        {
                            Console.Clear();
                            Console.Write("Выбрана операция умножения \nВведите первое число: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            float b = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Результат умножения: {mul(a, b)} \nНажмите любую кнопку для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.Oem2:
                        {
                            Console.Clear();
                            Console.Write("Выбрана операция деления \nВведите первое число: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            float b = float.Parse(Console.ReadLine());
                            if (b == 0) Console.WriteLine("\nВнимание! Обнаружено деление на 0!");
                            else Console.WriteLine($"\nРезультат деления: {div(a, b)}");
                            Console.WriteLine("\nНажмите любую кнопку для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return;
                        }
                }
            }
        }
    }
}