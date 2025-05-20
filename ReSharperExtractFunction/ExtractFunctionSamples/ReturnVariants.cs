namespace ExtractFunctionSamples
{
    public class ReturnVariants
    {
        // Example 1: Method with int return
        public int ReturnInt()
        {
            int x = 5;
            int y = x + 10;
            return y;
        }

        // Example 2: Method with object return
        public object ReturnObject()
        {
            var data = new { FileName = "Report.cs", LineCount = 120 };
            return data;
        }

        // Example 3: Method with void return
        public void ReturnVoid()
        {
            Console.WriteLine("Void method");
        }

        // Example 4: Conditional return
        public int ConditionalReturn(bool flag)
        {
            if (flag)
                return 1;
            else
                return 0;
        }

        // Example 5: Conditional expression
        public string ReturnWithTernary(bool isValid)
        {
            return isValid ? "ok" : "fail";
        }
    }
}
