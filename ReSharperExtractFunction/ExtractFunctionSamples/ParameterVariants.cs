namespace ExtractFunctionSamples
{
    public class ParameterVariants
    {
        // Example 1: ref parameter
        public void RefParameter(ref int x)
        {
            x += 10;
            Console.WriteLine(x);
        }

        // Example 2: out parameter
        public void OutParameter(out int result)
        {
            result = 42;
            Console.WriteLine("Result assigned");
        }

        // Example 3: in parameter
        public void InParameter(in int value)
        {
            Console.WriteLine(value * 2);
        }

        // Example 4: Default parameter
        public void DefaultParameter(int a, int b = 5)
        {
            Console.WriteLine(a + b);
        }

        // Example 5: Many parameters with mixed modifiers
        public void MixedParameters(int a, ref int b, out int c, int d = 10)
        {
            b += d;
            c = a + b + d;
            Console.WriteLine($"c = {c}");
        }
    }
}
