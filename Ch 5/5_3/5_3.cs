namespace _5_3
{
    /// <summary>
    /// Called this in Java, C++, C#
    /// Called self in Smalltalk, Objective-C, Object Pascal
    /// Called current in Eiffel
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard myCard = new PlayingCard(3);
        }
    }

    class PlayingCard
    {
        private ushort rank;

        /// <summary>
        /// Using this to resolve a name
        /// </summary>
        /// <param name="rank"></param>
        public PlayingCard(ushort rank)
        {
            this.rank = rank;
        }

        /// <summary>
        /// Within a method a message expression or a data access with no explicit receiver is implicitly assumed to refer to this:
        /// </summary>
        public int Rank
        {
            get
            {
                //return this.rank;
                return rank;
            }
        }

        public PlayingCard GetNext()
        {
            return this;
        }
    }
}