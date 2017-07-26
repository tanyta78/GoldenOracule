using System.Collections.Generic;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiancePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }

        public Quest(int id, string name, string description, int rewardExperiancePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiancePoints = rewardExperiancePoints;
            RewardGold = rewardGold;
            QuestCompetionItems = new List<QuestCompetionItem>();
        }

        public List<QuestCompetionItem> QuestCompetionItems { get; set; }
    }
}