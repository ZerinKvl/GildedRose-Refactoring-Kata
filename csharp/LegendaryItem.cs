
namespace csharp
{
    public class LegendaryItem : TargetItem
    {
        public LegendaryItem(Item item) : base(item)
        {

        }
        public override void CalculateSellByDate()
        {

        }
        public override void CalculateQuality()
        {
           
        }
        public override void SpecifyQualityValue()
        {
            Item.Quality = 80;
        }
    }
}
