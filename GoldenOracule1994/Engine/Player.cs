using System.Collections.Generic;

namespace Engine
{

   public class Player:LivingCreature
    {
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiancePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiancePoints = experiancePoints;
            Level = level;
            Inventory=new List<InventoryItem>();
            Quests=new List<PlayerQuest>();
        }

        public int Gold { get; set; }
        public int ExperiancePoints { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
    }
}
