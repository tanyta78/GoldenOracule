namespace Engine
{
    public class QuestCompetionItem
    {
        public QuestCompetionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }

        public Item Details { get; set; }
        public int Quantity { get; set; }
    }
}