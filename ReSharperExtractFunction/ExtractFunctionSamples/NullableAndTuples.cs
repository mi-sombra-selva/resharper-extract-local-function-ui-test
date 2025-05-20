namespace ExtractFunctionSamples
{
    public class NullableAndTuples
    {
        // Example 1: Nullable reference types
        public void PrintLength(string? input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine(input.Length);
            }
            else
            {
                Console.WriteLine("Input is null or empty");
            }
        }

        // Example 2: Nullable value types
        public void ProcessNullableInt(int? value)
        {
            if (value.HasValue)
            {
                Console.WriteLine(value.Value);
            }
            else
            {
                Console.WriteLine("No value");
            }
        }

        // Example 3: Tuple return
        public (int, string) GetTuple()
        {
            return (42, "answer");
        }

        // Example 4: Deconstruction
        public void UseDeconstruction()
        {
            var (num, text) = GetTuple();
            Console.WriteLine($"{num}: {text}");
        }

        // Example 5: Complex tuple usage
        public void ProcessTuple((string name, int age, bool active)? user)
        {
            if (user.HasValue && user.Value.active)
            {
                Console.WriteLine($"{user.Value.name} is active and {user.Value.age} years old.");
            }
        }
    }
}
