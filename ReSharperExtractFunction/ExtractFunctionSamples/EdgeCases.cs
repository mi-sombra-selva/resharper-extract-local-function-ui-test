namespace ExtractFunctionSamples
{
    public class EdgeCases
    {
        // Example 1: Single return statement
        public void JustReturn()
        {
            return;
        }

        // Example 2: Partial statement selection (may not extract)
        public void PartialStatement()
        {
            int x = 5;
            int y = x + 10; // try selecting only this line
            Console.WriteLine(y);
        }

        // Example 3: Comment-only selection
        public void CommentOnly()
        {
            // This is just a comment
        }

        // Example 4: Preprocessor directive
        public void WithDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#endif
        }

        // Example 5: Mismatched block
        public void UnbalancedBlock()
        {
            if (true)
            {
                Console.WriteLine("Start");
                // try selecting without closing brace
            }
        }
    }
}
