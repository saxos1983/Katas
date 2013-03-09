namespace Tennis
{
    public interface ITennisScorer
    {
        void AchievesScore(Player player);

        string GameScore { get; }
    }

    public enum Player
    {
        PlayerA, 
        PlayerB
    }
}
