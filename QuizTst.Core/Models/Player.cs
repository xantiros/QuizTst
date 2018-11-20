using System.Collections.Generic;

namespace QuizTst.Core.Models
{
    public class Player
    {
        public int Total_Points { get; private set; }
        public int Level1_Points { get; private set; }
        public int Level2_Points { get; private set; }
        public int Level3_Points { get; private set; }

        public Player(int total_points, int level1_points, int level2_points, int level3_points)
        {
            Total_Points = total_points;
            Level1_Points = level1_points;
            Level2_Points = level2_points;
            Level3_Points = level3_points;
        }
        public void AddTotalPoints()
        {
            Total_Points++;
        }
        public void AddLevel1Points()
        {
            Level1_Points++;
        }
        public void AddLevel2Points()
        {
            Level2_Points++;
        }
        public void AddLevel3Points()
        {
            Level3_Points++;
        }
        protected Player()
        {
        }
    }
}
