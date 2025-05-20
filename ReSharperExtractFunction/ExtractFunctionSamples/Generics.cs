namespace ExtractFunctionSamples
{
    public class Generics
    {
        // Example 1: Generic method
        public T Identity<T>(T value)
        {
            return value;
        }

        // Example 2: Generic method with constraint
        public T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        // Example 3: Generic method in generic class
        public class Wrapper<T>
        {
            public T Value { get; set; }

            public void Print()
            {
                Console.WriteLine(Value);
            }
        }

        // Example 4: Method with multiple generic parameters
        public TResult Combine<T1, T2, TResult>(T1 a, T2 b, Func<T1, T2, TResult> combiner)
        {
            return combiner(a, b);
        }

        // Example 5: Use of generic delegate
        public void GenericDelegateExample()
        {
            Func<int, string> intToString = x => x.ToString();
            Console.WriteLine(intToString(42));
        }
    }
}
