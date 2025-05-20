namespace ExtractFunctionSamples
{
    public class MixedComplex
    {
        // Example: Combined use of async, generics, lambdas, and local functions
        public async Task ProcessDataAsync<T>(List<T> items, Func<T, bool> predicate) where T : class
        {
            if (items == null || items.Count == 0)
            {
                Console.WriteLine("No items");
                return;
            }

            List<string> results = new();

            async Task<string> TransformAsync(T item)
            {
                await Task.Delay(10);
                return item.ToString() ?? "null";
            }

            foreach (var item in items.Where(predicate))
            {
                string result = await TransformAsync(item);
                results.Add(result);
            }

            results
                .Select((value, index) => $"{index}: {value}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
