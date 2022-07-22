
namespace csharp
{
    public class ItemFactory : ItemCreator
    {
        public override ITarget CreateItemInstance(Item item)
        {
            if (item.Name.Contains("Aged Brie"))
                return new ItemManager(new AgedBrieItem(item)).targetItem;
            if (item.Name.Contains("Backstage"))
                return new ItemManager(new BackstagePassItem(item)).targetItem;
            if (item.Name.Contains("Sulfuras"))
                return new ItemManager(new LegendaryItem(item)).targetItem;
            if (item.Name.Contains("Conjured"))
                return new ItemManager(new ConjuredItem(item)).targetItem;

            return new ItemManager(new TargetItem(item)).targetItem;
        }
    }
}
