using System.Collections.Generic;

namespace Engine
{
    public class Player : LivingCreature
    {
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiancePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiancePoints = experiancePoints;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public int Gold { get; set; }
        public int ExperiancePoints { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequeredToEnter == null)
            {
                return true;
            }

            foreach (var inventoryItem in Inventory)
            {
                if (inventoryItem.Details.ID == location.ItemRequeredToEnter.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                {
                    return true;
                }
            }

            return false;
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
                bool foundItemInPlayersInventory = false;

                foreach (InventoryItem inventoryItem in Inventory)
                {
                    if (inventoryItem.Details.ID == questCompetionItem.Details.ID)
                    {
                        foundItemInPlayersInventory = true;

                        if (inventoryItem.Quantity < questCompetionItem.Quantity)
                        {
                            return false;
                        }
                    }
                }

                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }

            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompetionItem questQuestCompetionItem in quest.QuestCompetionItems)
            {
                foreach (InventoryItem inventoryItem in Inventory)
                {
                    if (inventoryItem.Details.ID == questQuestCompetionItem.Details.ID)
                    {
                        inventoryItem.Quantity -= questQuestCompetionItem.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            foreach (var inventoryItem in Inventory)
            {
                if (inventoryItem.Details.ID == itemToAdd.ID)
                {
                    inventoryItem.Quantity++;

                    return;
                }
            }

            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        public void MarkQuestCompleted(Quest quest)
        {
            foreach (var playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                {
                    playerQuest.IsCompleted = true;

                    return;
                }
            }
        }
    }
}