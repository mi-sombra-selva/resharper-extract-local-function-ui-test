namespace ExtractFunctionSamples
{
    public class StaticContext
    {
        // Example 1: Static method
        public static void StaticHello()
        {
            Console.WriteLine("Hello from static method");
        }

        // Example 2: Static method using static field
        private static int _counter = 0;

        public static void IncrementCounter()
        {
            _counter++;
            Console.WriteLine($"Counter: {_counter}");
        }

        // Example 3: Static method with computation
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Example 4: Static method calling another static method
        public static void CallAnother()
        {
            var result = Multiply(3, 4);
            Console.WriteLine(result);
        }

        // Example 5: Static method with local static function
        public static void WithLocalStatic()
        {
            int x = 5;

            static int Square(int n) => n * n;

            Console.WriteLine(Square(x));
        }
    }
}
