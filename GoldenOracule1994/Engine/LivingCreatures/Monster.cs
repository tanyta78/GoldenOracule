using System.Collections.Generic;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public Monster(int id, string name, int maximumDamage, int rewardExperiancePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiancePoints = rewardExperiancePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiancePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
    }
}