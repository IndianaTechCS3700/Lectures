namespace _5_5
{
    /// <summary>
    /// Because in most languages objects are dynamically allocated, they must be recovered at run-time.
    /// There are two broad approaches to this:
    ///     * Force the programmer to free the memory
    ///     * Use garbage collection
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ExampleOne();

            ExampleTwo();
        }

        private static void ExampleTwo()
        {
            PlayingCard cardOne;
            PlayingCard cardTwo;

            cardOne = new PlayingCard();
            cardTwo = cardOne;

            cardOne = new PlayingCard();
        }

        private static void ExampleOne()
        {
            PlayingCard cardOne = new PlayingCard();
            cardOne.Rank = 4;

            cardOne = new PlayingCard();
            cardOne.Rank = 5;
        }
    }

    enum Suits
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    class PlayingCard
    {
        public int Rank { get; set; }
        public Suits Suit { get; set; }
    }
}