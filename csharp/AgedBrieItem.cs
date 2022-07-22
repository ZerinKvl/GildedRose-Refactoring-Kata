
namespace csharp
{
    public class AgedBrieItem : TargetItem
    {
        public AgedBrieItem(Item item) : base(item)
        {

        }
        public override void CalculateQuality()
        {
            Item.Quality++;
            if (Item.SellIn < 0)
            {
                Item.Quality++;

            }
        }
    }
}
