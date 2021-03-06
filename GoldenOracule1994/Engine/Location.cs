﻿namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Vendor VendorWorkingHere { get; set; }

        public Location(int id, string name, string description, Item itemRequeredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequeredToEnter = itemRequeredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }

        public Item ItemRequeredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToSouth { get; set; }
    }
}