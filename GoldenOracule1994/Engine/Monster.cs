using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Monster : LivingCreature
    {
        public Monster(int currentHitPoints, int maximumHitPoints, int id, string name, int maximumDamage, int rewardExperiancePoints, int rewardGold) : base(currentHitPoints, maximumHitPoints)
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
