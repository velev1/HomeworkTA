namespace WalkInMatrix
{
    using Contracts;

    public class InputReader
    {
        public InputReader(IReader reader)
        {
            this.Use = reader;
        }

        public IReader Use { get; private set; }
    }
}
