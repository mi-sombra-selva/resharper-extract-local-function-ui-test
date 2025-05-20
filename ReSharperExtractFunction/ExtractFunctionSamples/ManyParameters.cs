namespace ExtractFunctionSamples
{
    public class ManyParameters
    {
        // Example 1: Method with many parameters of different types
        public void ComplexSignature(int a, int b, string c, bool d, double e, ref int f, out int g, int h = 100)
        {
            f += a + b;
            g = f * 2;

            if (d && !string.IsNullOrEmpty(c))
            {
                Console.WriteLine($"{c} - {g + h + (int)e}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        // Example 2: All parameters used in different ways
        public void ParameterChaos(string s, int x, float y, bool z, object o, DateTime dt, char ch, ref string tag, out int result)
        {
            result = x + (int)y;
            tag += s + ch;

            if (z)
            {
                Console.WriteLine($"[{dt}] {tag}: {o} => {result}");
            }
        }
    }
}
