namespace quest18._1
{
    internal class Operation
    {
        public double Average(double x, double y, double z)
        {
            return Math.Round((x + y + z)/3, 2);
        }
    }
    public delegate double DelAverage(double x, double y, double z);
    internal class Program
    {
        static void Main()
        {
            Operation math = new();
            DelAverage DelAverage = new(math.Average);
            double getAverage = math.Average(3,4,7);
            Console.WriteLine(getAverage);
            Console.ReadKey();
        }
    }
}