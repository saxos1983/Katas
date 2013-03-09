namespace Tennis.Test
{
    using NUnit.Framework;
    using FluentAssertions;

    [TestFixture]
    public class TennisScorerTest
    {
        private TennisScorer testee;

        [SetUp]
        public void SetUp()
        {
            testee = new TennisScorer();
        }

        [TestCase("", "love")]
        [TestCase("A", "15:0")]
        [TestCase("AAB", "30:15")]
        [TestCase("AAAB", "40:15")]
        [TestCase("BBB", "0:40")]
        [TestCase("BBB", "0:40")]
        [TestCase("ABABAB", "deuce")]
        [TestCase("AAABBB", "deuce")]
        [TestCase("AABBAB", "deuce")]
        [TestCase("AAABBBA", "advantageA")]
        [TestCase("AAABBBB", "advantageB")]
        [TestCase("AAAA", "gameA")]
        [TestCase("AAAAA", "gameA")]        
        [TestCase("AAAABBBBBB", "gameA")]
        [TestCase("AAABBBBB", "gameB")]
        [TestCase("ABABABABABABABABABABABAA", "gameA")]
        public void PlayerScores(string game, string expectedScores)
        {
            foreach (var currentScore in game)
            {
                switch (currentScore)
                {
                    case 'A':
                        testee.Scores(Player.PlayerA);
                        break;
                    case 'B':
                        testee.Scores(Player.PlayerB);
                        break;
                }
            }
            testee.Score.Should().Be(expectedScores);
        }
    }
}