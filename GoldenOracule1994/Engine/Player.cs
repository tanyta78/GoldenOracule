namespace Engine
{
   public class Player:LivingCreature
    {
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiancePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiancePoints = experiancePoints;
            Level = level;
        }

        public int Gold { get; set; }
        public int ExperiancePoints { get; set; }
        public int Level { get; set; }
    }
}
