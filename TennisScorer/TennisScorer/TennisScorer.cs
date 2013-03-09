namespace Tennis
{
    public class TennisScorer : ITennisScorer
    {
        private int ScoreA;
        private int ScoreB;

        private const string GameA = "gameA";
        private const string GameB = "gameB";
        private const string AdvantageA = "advantageA";
        private const string AdvantageB = "advantageB";

        private static readonly string[][] PlayerScores = new[]
            {
                new[] {"love",  "15:0",     "30:0",     "40:0",     GameA},
                new[] {"0:15",  "15:15",    "30:15",    "40:15",    GameA},
                new[] {"0:30",  "15:30",    "30:30",    "40:30",    GameA},
                new[] {"0:40",  "15:40",    "30:40",    "deuce",    AdvantageA},
                new[] { GameB,   GameB,     GameB,      AdvantageB}
            };

        public void Scores(Player player)
        {
            switch (player)
            {
                case Player.PlayerA:
                    ScorePlayer(ref ScoreA, ref ScoreB);
                    break;
                case Player.PlayerB:
                    ScorePlayer(ref ScoreB, ref ScoreA);
                    break;
            }
        }

        public string Score
        {
            get { return PlayerScores[ScoreB][ScoreA]; }
        }

        private void ScorePlayer(ref int playerToAddScore, ref int opponentScore)
        {
            if (Score == AdvantageA || Score == AdvantageB)
            {
                opponentScore--;
            }
            else if (Score != GameA && Score != GameB)
            {
                playerToAddScore++;
            }
        }
    }
}