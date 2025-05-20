namespace ExtractFunctionSamples
{
    public class LocalFunctions
    {
        // Example 1: Simple local function
        public void SimpleLocalFunction()
        {
            int Add(int a, int b) => a + b;
            Console.WriteLine(Add(2, 3));
        }

        // Example 2: Local function calling another local function
        public void NestedLocalFunctions()
        {
            int Outer(int x)
            {
                int Inner(int y) => y * 2;
                return Inner(x) + 1;
            }

            Console.WriteLine(Outer(5));
        }

        // Example 3: Local function capturing variable
        public void LocalCapturesVariable()
        {
            int z = 10;
            int MultiplyByZ(int x) => x * z;
            Console.WriteLine(MultiplyByZ(4));
        }

        // Example 4: Local function with recursion
        public void RecursiveLocalFunction()
        {
            int Factorial(int n)
            {
                if (n <= 1) return 1;
                return n * Factorial(n - 1);
            }

            Console.WriteLine(Factorial(5));
        }

        // Example 5: Local function with conditional logic
        public void ConditionalLocalFunction(bool flag)
        {
            int ChooseValue()
            {
                return flag ? 1 : -1;
            }

            Console.WriteLine(ChooseValue());
        }
    }
}
