namespace Tennis
{
    /// <summary>
    /// The TennisScorer interface.
    /// </summary>
    public interface ITennisScorer
    {
        void Scores(Player player);

        string Score { get; }
    }

    public enum Player
    {
        PlayerA, 
        PlayerB
    }
}
