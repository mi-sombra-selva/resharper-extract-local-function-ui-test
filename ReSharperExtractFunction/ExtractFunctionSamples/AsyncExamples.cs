namespace ExtractFunctionSamples
{
    public class AsyncExamples
    {
        // Example 1: Simple async method
        public async Task SimpleAsync()
        {
            await Task.Delay(100);
            Console.WriteLine("Done");
        }

        // Example 2: Await inside LINQ
        public async Task LinqWithAwait()
        {
            var inputs = new[] { 1, 2, 3 };
            var tasks = inputs.Select(async x =>
            {
                await Task.Delay(x * 10);
                return x * 2;
            });
            var results = await Task.WhenAll(tasks);
            Console.WriteLine(string.Join(", ", results));
        }

        // Example 3: ConfigureAwait
        public async Task WithConfigureAwait()
        {
            await Task.Delay(50).ConfigureAwait(false);
            Console.WriteLine("Continued on another context");
        }

        // Example 4: ValueTask
        public async ValueTask<int> WithValueTask()
        {
            await Task.Yield();
            return 42;
        }

        // Example 5: Async inside condition
        public async Task AsyncCondition(bool shouldRun)
        {
            if (shouldRun)
            {
                await Task.Delay(20);
                Console.WriteLine("Executed async path");
            }
            else
            {
                Console.WriteLine("Skipped");
            }
        }
    }
}
