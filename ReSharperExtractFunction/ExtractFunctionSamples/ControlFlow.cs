namespace ExtractFunctionSamples
{
    public class ControlFlow
    {
        // Example 1: If-else
        public void IfElseExample(int value)
        {
            if (value > 10)
            {
                Console.WriteLine("Greater than 10");
            }
            else
            {
                Console.WriteLine("10 or less");
            }
        }

        // Example 2: Switch
        public void SwitchExample(int x)
        {
            switch (x)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }

        // Example 3: For loop
        public void ForLoopExample()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"i = {i}");
            }
        }

        // Example 4: While loop with break
        public void WhileWithBreak()
        {
            int i = 0;
            while (true)
            {
                if (i >= 3) break;
                Console.WriteLine(i);
                i++;
            }
        }

        // Example 5: Try-catch-finally
        public void TryCatchFinally()
        {
            try
            {
                Console.WriteLine("In try");
                throw new Exception();
            }
            catch
            {
                Console.WriteLine("Caught");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
