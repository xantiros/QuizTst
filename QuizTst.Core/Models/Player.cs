using System.Collections.Generic;

namespace QuizTst.Core.Models
{
    public class Player
    {
        public int TotalPoints { get; private set; }
        public int Level1Points { get; private set; }
        public int Level2Points { get; private set; }
        public int Level3Points { get; private set; }

        public Player(int total_points, int level1_points, int level2_points, int level3_points)
        {
            TotalPoints = total_points;
            Level1Points = level1_points;
            Level2Points = level2_points;
            Level3Points = level3_points;
        }
        public void AddTotalPoints()
        {
            TotalPoints++;
        }
        public void AddLevel1Points()
        {
            Level1Points++;
        }
        public void AddLevel2Points()
        {
            Level2Points++;
        }
        public void AddLevel3Points()
        {
            Level3Points++;
        }
        protected Player()
        {
        }
    }
}
