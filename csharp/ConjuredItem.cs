
namespace csharp
{
    public class ConjuredItem : TargetItem
    {
        public ConjuredItem(Item item) : base(item)
        {

        }
        public override void CalculateQuality()
        {
            Item.Quality--;
            if (Item.SellIn < 0)
            {
                Item.Quality -= 1;
            }
        }
    }
}
