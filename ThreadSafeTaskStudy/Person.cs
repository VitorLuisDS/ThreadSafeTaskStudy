namespace ThreadSafeTaskStudy
{
    internal class PersonClass
    {
        public int Code { get; set; }

        public void SafeIncrementCode(int taskNum)
        {
            lock (this)
            {
                Console.WriteLine($"Task #{taskNum} - Running safe code increment...");
                IncrementCode(taskNum);
                Console.WriteLine($"Task #{taskNum} - End of safe code increment.");
            }
        }

        public void UnsafeIncrementCode(int taskNum)
        {
            Console.WriteLine($"Task #{taskNum} - Running unsafe code increment...");
            IncrementCode(taskNum);
            Console.WriteLine($"Task #{taskNum} - End of unsafe code increment.");
        }
        private void IncrementCode(int taskNum)
        {
            Console.WriteLine($"Task #{taskNum} - Code before execution: {Code}");
            Code++;
            Console.WriteLine($"Task #{taskNum} - Code after execution: {Code}");
        }
    }
}
