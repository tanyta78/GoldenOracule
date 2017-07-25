using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Player : LivingCreature
    {
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiancePoints) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiancePoints = experiancePoints;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public int Gold { get; set; }
        public int ExperiancePoints { get; set; }

        public int Level
        {
            get { return ((ExperiancePoints / 100) + 1); }
        }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequeredToEnter == null)
            {
                return true;
            }

            return Inventory.Exists(ii => ii.Details.ID == location.ItemRequeredToEnter.ID);
        }

        public bool HasThisQuest(Quest quest)
        {
            return Quests.Exists(pq => pq.Details.ID == quest.ID);
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest)
        {
            foreach (var questCompetionItem in quest.QuestCompetionItems)
            {
                if (!Inventory.Exists(ii => ii.Details.ID == questCompetionItem.Details.ID && ii.Quantity >= questCompetionItem.Quantity))
                {
                    return false;
                }
            }

            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompetionItem questCompetionItem in quest.QuestCompetionItems)
            {
                InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == questCompetionItem.Details.ID);

                if (item != null)
                {
                    item.Quantity -= questCompetionItem.Quantity;
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if (item == null)
            {
                Inventory.Add(new InventoryItem(itemToAdd, 1));
            }
            else
            {
                item.Quantity++;
            }
        }

        public void MarkQuestCompleted(Quest quest)
        {
            PlayerQuest playerQuest = Quests.SingleOrDefault(pq => pq.Details.ID == quest.ID);

            if (playerQuest != null)
            {
                playerQuest.IsCompleted = true;
            }
        }
    }
}