namespace ExtractFunctionSamples
{
    public class SimpleExamples
    {
        // Example 1: Two sequential statements
        public void SimpleSequence_01()
        {
            int x = 5;
            int y = x + 10;
            Console.WriteLine(y);
        }

        // Example 2: Statement with comment
        public void SimpleSequence_02()
        {
            int a = 3;
            // this is a simple multiplication
            int b = a * 2;
            Console.WriteLine(b);
        }

        // Example 3: Declaration and usage
        public void SimpleSequence_03()
        {
            string message = "Hello";
            Console.WriteLine(message);
        }

        // Example 4: No parameters, no return
        public void NoParamsNoReturn()
        {
            Console.WriteLine("Just printing something");
        }

        // Example 5: Variable declared but unused
        public void UnusedVariable()
        {
            int z = 100;
        }
    }
}
