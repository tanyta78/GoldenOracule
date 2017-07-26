namespace Engine
{
    public class LootItem
    {
        public LootItem(Item details, int dropPersentage, bool isDefaultItem)
        {
            Details = details;
            DropPersentage = dropPersentage;
            IsDefaultItem = isDefaultItem;
        }

        public Item Details { get; set; }
        public int DropPersentage { get; set; }
        public bool IsDefaultItem { get; set; }
    }
}