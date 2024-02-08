namespace quest18._3
{
    public delegate int Number();
    public delegate float MediumCalc(Number[] arrayX);
    class Program
    {
        public static int Randomizer()
        {
            Random rand = new();
            return rand.Next(1, 10);
        }

        static void Main()
        {
            Number[] numArr = new Number[5];
            Console.Write("Сгенерированные случайные числа:");
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = Randomizer;
                Console.Write(" " + numArr[i].Invoke() + " ");
            }
            Console.WriteLine();

            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i]();
                }
                return (sum / arrayX.Length);
            };
            Console.WriteLine("Итоговое среднее арифметическое: " + mediumCalc(numArr));
        }
    }
}