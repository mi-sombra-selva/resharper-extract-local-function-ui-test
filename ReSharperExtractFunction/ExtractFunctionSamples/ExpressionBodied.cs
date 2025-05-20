namespace ExtractFunctionSamples
{
    public class ExpressionBodied
    {
        // Example 1: Expression-bodied method
        public int Square(int x) => x * x;

        // Example 2: Expression-bodied property
        public string Greeting => "Hello";

        // Example 3: Expression-bodied method with conditional logic
        public string Status(bool isOk) => isOk ? "OK" : "Fail";

        // Example 4: Expression-bodied method returning object
        public object GetAnonymous() => new { Name = "Test", Value = 42 };

        // Example 5: Expression-bodied method calling another
        public void PrintResult() => Console.WriteLine(Square(5));
    }
}
