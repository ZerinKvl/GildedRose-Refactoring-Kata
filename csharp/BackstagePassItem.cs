using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class BackstagePassItem : TargetItem
    {
        public BackstagePassItem(Item item) : base(item)
        {

        }
        public override void CalculateQuality()
        {

            if (Item.SellIn < 10 && Item.SellIn >= 5)
            {
                Item.Quality += 1;
            }

            if (Item.SellIn < 5 && Item.SellIn >= 0)
            {
                Item.Quality += 2;
            }

            Item.Quality += 1;


            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }

        }
    }
}
