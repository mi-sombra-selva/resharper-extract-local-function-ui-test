namespace ExtractFunctionSamples
{
    public class LargeCodeBlocks
    {
        // Example: Long and complex block of logic
        public void ComplexWorkflow()
        {
            int total = 0;
            int multiplier = 3;
            List<int> data = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                data.Add(i * multiplier);
            }

            Console.WriteLine("Data populated:");
            foreach (var val in data)
            {
                Console.WriteLine(val);
            }

            int evenSum = 0;
            int oddSum = 0;

            foreach (var val in data)
            {
                if (val % 2 == 0)
                    evenSum += val;
                else
                    oddSum += val;
            }

            total = evenSum + oddSum;
            Console.WriteLine($"Even sum: {evenSum}, Odd sum: {oddSum}, Total: {total}");

            var grouped = data.GroupBy(x => x % 3 == 0 ? "DivBy3" : "Other");
            foreach (var group in grouped)
            {
                Console.WriteLine($"Group: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item}");
                }
            }

            var filtered = data.Where(x => x > 10).Select(x => x.ToString()).ToList();
            Console.WriteLine("Filtered items:");
            filtered.ForEach(Console.WriteLine);

            Console.WriteLine("Workflow completed.");
        }
    }
}
