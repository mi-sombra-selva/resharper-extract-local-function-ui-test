namespace ExtractFunctionSamples
{
    public class LambdasAndAnonymous
    {
        // Example 1: Simple lambda in LINQ
        public void LinqLambda()
        {
            var nums = new[] { 1, 2, 3 };
            var doubled = nums.Select(x => x * 2);
            Console.WriteLine(string.Join(", ", doubled));
        }

        // Example 2: Nested lambda
        public void NestedLambda()
        {
            Func<int, Func<int, int>> adder = x => y => x + y;
            var result = adder(3)(4);
            Console.WriteLine(result);
        }

        // Example 3: Lambda as method argument
        public void LambdaAsArgument()
        {
            Run(x => x * x);
        }

        private void Run(Func<int, int> func)
        {
            Console.WriteLine(func(5));
        }

        // Example 4: Anonymous method
        public void AnonymousMethod()
        {
            Func<int, int> square = delegate (int x) { return x * x; };
            Console.WriteLine(square(6));
        }

        // Example 5: Lambda with side effects
        public void LambdaWithSideEffects()
        {
            int counter = 0;
            Action increment = () => { counter++; Console.WriteLine(counter); };
            increment();
            increment();
        }
    }
}
