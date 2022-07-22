
namespace csharp
{
    public class TargetItem : ITarget
    {
        public Item Item { get; set; }

        public TargetItem(Item item)
        {
            this.Item = item;
        }
        public virtual void CalculateSellByDate()
        {
            this.Item.SellIn -= 1;
        }
        public virtual void CalculateQuality()
        {
            Item.Quality--;
            if (Item.SellIn < 0)
            {
                Item.Quality--;
            }
        }
        public virtual void SpecifyQualityValue()
        {
            if (Item.Quality < 0)
            {
                Item.Quality = 0;
            }
            else if (Item.Quality > 50)
            {
                Item.Quality = 50;
            }
        }
    }
}
